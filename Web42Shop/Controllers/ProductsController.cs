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
        public IActionResult Index(int? page)
        {
            int p = (!page.HasValue) ? 1 : page.Value;
            if (page <= 0) return NotFound();
            ListItemProductsViewModel homeProducts = new ListItemProductsViewModel
            {
                CurrentPage = p,
                TotalPage = GetTotalPage(),
                ItemProducts = GetAllProducts(p)
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
        //hàm cho phần phân trang12
        private int GetTotalPage(){
            int sl = _context.Products.Count();
            int total = (sl % 8 == 0) ? (sl / 8) : (sl / 8) + 1; 
            return total;
        }
        private List<ItemProductsViewModel> GetAllProducts(int page){
            page--;
            List<ItemProductsViewModel> pro = new List<ItemProductsViewModel>();
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
            pro = query.Skip(page*8).Take(8).ToList();
            return pro;

        }
    }
}
