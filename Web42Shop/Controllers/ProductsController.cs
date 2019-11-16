using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web42Shop.Data;
using Web42Shop.Models;
using Web42Shop.ViewModels;

namespace Web42Shop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly Web42ShopDbContext _context;

        public ProductsController(Web42ShopDbContext context)
        {
            _context = context;
        }

        // GET: Products

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Admin)
                .Include(p => p.ProductBrand)
                .Include(p => p.ProductType)
                .Include(p => p.Slug)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        [Route("~/{type}/{NameUrl}")]
        public async Task<IActionResult> Single(string type,string NameUrl)
        {
            int page = 1;
            Product singleProduct = await (from p in _context.Products
                                           join s in _context.Slugs
                                           on p.Slug_Id equals s.Id
                                           join t in _context.ProductTypes
                                           on p.ProductType_Id equals t.Id
                                           //where s.Url == NameUrl && t.
                                           select p).SingleOrDefaultAsync();

            if (singleProduct == null) return NotFound();
            
            string productType = await (from t in _context.ProductTypes 
                                        where t.Id == singleProduct.ProductType_Id
                                        select t.Type).SingleOrDefaultAsync();
            string productBrand = await (from b in _context.ProductBrands
                                         where b.Id == singleProduct.ProductType_Id
                                         select b.Name).SingleOrDefaultAsync();
            SingleProductViewModel viewModel = new SingleProductViewModel
            {
                SingleProduct = singleProduct,
                ProductType = productType,
                ProductBrand = productBrand,
                Url = NameUrl,
                ProductsSimilar = await GetProducts(getInt32ForQuery("GetListProductsFormType"), 1, productType),
                ProductComments = await GetCommentById(singleProduct.Id, page),
                ProductTypes = await _context.ProductTypes.ToListAsync(),
            };
            return View( viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> ListProducts(string type, int ?page)
        {
            int p = (!page.HasValue) ? 1 : page.Value;
            int option = getInt32ForQuery("GetListProductsFormType");
            if (p <= 0) return NotFound();
            ListItemProductsViewModel viewmodel = new ListItemProductsViewModel
            {
                Value = "Loại: " + type,
                CurrentPage = p,
                TotalPage = await GetTotalPage(option, type),
                ItemProducts = await GetProducts(option, p, type),
                ProductTypes = await _context.ProductTypes.ToListAsync(),
                OrderBy = type
            };
            return View(viewmodel);
        }
        [HttpGet]
        public async Task<IActionResult> SearchProducts(string key_s, int? page)
        {
            if (key_s == null) 
                return RedirectToAction("Index", "Products");
            int p = (!page.HasValue) ? 1 : page.Value;
            int option = getInt32ForQuery("SearchByName");
            if (p <= 0) return NotFound();
            ListItemProductsViewModel viewmodel = new ListItemProductsViewModel
            {
                Value = key_s,
                CurrentPage = p,
                TotalPage = await GetTotalPage(option, key_s),
                ItemProducts = await GetProducts(option, p, key_s),
                ProductTypes = _context.ProductTypes.ToList(),
                OrderBy = "SearchByName",
            };
            return View(viewmodel);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["Admin_Id"] = new SelectList(_context.Admins, "Id", "Email", product.Admin_Id);
            ViewData["ProductBrand_Id"] = new SelectList(_context.ProductBrands, "Id", "Name", product.ProductBrand_Id);
            ViewData["ProductType_Id"] = new SelectList(_context.ProductTypes, "Id", "Type", product.ProductType_Id);
            ViewData["Slug_Id"] = new SelectList(_context.Slugs, "Id", "Url", product.Slug_Id);
            return View(product);
        }
        public async Task<IActionResult> Index(string order_by, int? page)
        {
            int p = (!page.HasValue) ? 1 : page.Value;
            if (order_by == null) order_by = "OrderByDateCreate";
            int option = getInt32ForQuery(order_by);
            if (p <= 0 || option == -1) return NotFound();
            ListItemProductsViewModel homeProducts = new ListItemProductsViewModel
            {
                Value = "Tất cả các sản phẩm ",
                TotalPage = await GetTotalPage(option, ""),
                CurrentPage = p,
                ItemProducts = await GetProducts(option, p, ""),
                ProductTypes = _context.ProductTypes.ToList(),
                OrderBy = order_by
            };
            return View(homeProducts);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductBrand_Id,ProductType_Id,Slug_Id,Admin_Id,Name,Description,Price,Saleoff,Thumbnail,Instore,Stars,BuyPoints,Views,Orders,DateCreate,DateModify")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("ProductsOverview", "Admin");
            }
            ViewData["Admin_Id"] = new SelectList(_context.Admins, "Id", "Email", product.Admin_Id);
            ViewData["ProductBrand_Id"] = new SelectList(_context.ProductBrands, "Id", "Name", product.ProductBrand_Id);
            ViewData["ProductType_Id"] = new SelectList(_context.ProductTypes, "Id", "Type", product.ProductType_Id);
            ViewData["Slug_Id"] = new SelectList(_context.Slugs, "Id", "Url", product.Slug_Id);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Admin)
                .Include(p => p.ProductBrand)
                .Include(p => p.ProductType)
                .Include(p => p.Slug)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }


            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("ProductsOverview", "Admin");
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
        //hàm cho phần phân trang
        private async Task<int> GetTotalPage(int option, string key)
        {
            int total;
            if (option == 0|| option == 1)
            {
                int sl = await _context.Products.CountAsync();
                total = (sl % 8 == 0) ? (sl / 8) : (sl / 8) + 1;
                return total;
            }
            else if (option == 2)
            {
                int sl = await (from p in _context.Products where p.Name.Contains(key.Trim()) select p).CountAsync();
                total = (sl % 8 == 0) ? (sl / 8) : (sl / 8) + 1;
                return total;
            }
            else if (option == 3)
            {
                int sl = await (from p in _context.Products
                         join t in _context.ProductTypes
                         on p.ProductType_Id equals t.Id
                         where t.Type == key
                         select p).CountAsync();
                total = (sl % 8 == 0) ? (sl / 8) : (sl / 8) + 1;
                return total;
            }
            return 0;
        }

        //hàm hỗ trợ khác //do Khải viết, có gì không hiểu liên lạc cho Khải

        [HttpPost]
        public async Task<IActionResult> MoreComment(int id, int page)
        {
            var com = await GetCommentById(id, page);
            int countCom = await (from c in _context.Comments where c.Product_Id == id select c).CountAsync();
            PerformCommentsViewModel viewmodel = new PerformCommentsViewModel
            {
                Comments = com,
                IdProduct = id,
                StillComments = (com.Count() < countCom) ? true : false
            };
            
            return PartialView("Users/_Comments", viewmodel);
        }
        private async Task<IEnumerable<CommentsViewModel>> GetCommentById(int id, int page)
        {
            page--;
            List<CommentsViewModel> comment = await (from c in _context.Comments join u in _context.Users
                                           on c.User_Id equals u.Id
                                           where c.Product_Id == id
                                           orderby c.DateCreate descending
                                           select new CommentsViewModel { 
                                                Id = c.Id,
                                                User = u.NameFirst + u.NameMiddle + u.NameLast,
                                                Product_Id = c.Product_Id,
                                                Stars = c.Stars,
                                                Content = c.Content,
                                                DateCreate = c.DateCreate,
                                                DateModify = c.DateModify
                                           }).Skip(0).Take(page*10+10).ToListAsync();
            return comment;
        }
        private async Task<List<ItemProductsViewModel>> GetProducts(int option, int page, string value)
        {
            page--;

            List<ItemProductsViewModel> product = new List<ItemProductsViewModel>();
            if (option == 0)
            {
                var query = (from p in _context.Products
                             orderby p.DateCreate descending
                             select new ItemProductsViewModel
                             {
                                 Id = p.Id,
                                 Name = p.Name,
                                 Price = p.Price,
                                 Saleoff = p.Saleoff,
                                 Thumbnail = p.Thumbnail,
                                 Stars = p.Stars,
                                 Views = p.Views,
                                 Orders = p.Orders
                             });
                product = await query.Skip(page * 8).Take(8).ToListAsync();
            }
            else if (option == 1)
            {
                var query = (from p in _context.Products
                             orderby p.Orders descending, p.Views descending
                             select new ItemProductsViewModel
                             {
                                 Id = p.Id,
                                 Name = p.Name,
                                 Price = p.Price,
                                 Saleoff = p.Saleoff,
                                 Thumbnail = p.Thumbnail,
                                 Stars = p.Stars,
                                 Views = p.Views,
                                 Orders = p.Orders
                             });
                product = await query.Skip(page * 8).Take(8).ToListAsync();
            }
            else if (option == 2)
            {
                var query = from p in _context.Products
                            where p.Name.Contains(value.Trim())
                            orderby p.DateCreate descending
                            select new ItemProductsViewModel
                            {
                                Id = p.Id,
                                Name = p.Name,
                                Price = p.Price,
                                Saleoff = p.Saleoff,
                                Thumbnail = p.Thumbnail,
                                Stars = p.Stars,
                                Views = p.Views,
                                Orders = p.Orders
                            };
                product = await query.Skip(page * 8).Take(8).ToListAsync();
            }
            else if(option == 3)
            {
                var query = from p in _context.Products
                            join t in _context.ProductTypes
                            on p.ProductType_Id equals t.Id
                            where t.Type == value
                            orderby p.DateCreate descending
                            select new ItemProductsViewModel
                            {
                                Id = p.Id,
                                Name = p.Name,
                                Price = p.Price,
                                Saleoff = p.Saleoff,
                                Thumbnail = p.Thumbnail,
                                Stars = p.Stars,
                                Views = p.Views,
                                Orders = p.Orders
                            };
                product = await query.Skip(page * 8).Take(8).ToListAsync();
            }
            return product;
        }
        private int getInt32ForQuery(string value)
        {
            if (value == "OrderByDateCreate")
            {
                return 0;
            }
            else if(value == "OrderByOrdersViews")
            {
                return 1;
            }
            else if( value == "SearchByName")
            {
                return 2;
            }
            else if( value == "GetListProductsFormType")
            {
                return 3;
            }
            return -1;
        }
       
    }
}