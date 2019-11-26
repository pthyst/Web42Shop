using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Web42Shop.Models;
using Web42Shop.Data;
using Web42Shop.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web42Shop.Controllers
{
    public class AdminController : Controller
    {
        private readonly Web42ShopDbContext _context;
        private readonly IHostingEnvironment _hostingEnviroment;
       

        public AdminController(Web42ShopDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnviroment = hostingEnvironment;
        }

        // SuperAdmin = 1, Admin = 2, Author = 3
        // Trang phân công
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("Role_Id") <= 3)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");

            }
        }

        // Trang đăng nhập
        public IActionResult Login()
        {
            HttpContext.Session.Remove("Role_Id");
            HttpContext.Session.Remove("Admin_Id");
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {

            var Auth = _context.Admins.Where(ad => ad.Username == admin.Username && ad.Password == admin.Password).FirstOrDefault();
            if (Auth == null)
            {
                ViewBag.Error = "Please Enter Correct Username And Password";
                return View("Login");
            }
            else if (Auth.Role_Id <= 3) 
            {
                HttpContext.Session.SetInt32("Role_Id", Auth.Role_Id);
                HttpContext.Session.SetInt32("Admin_Id", Auth.Id);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // Trang tổng quát các đơn hàng
        public IActionResult OrdersOverview()
        {
            if (HttpContext.Session.GetInt32("Role_Id") <= 3)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");

            }
        }

        // Trang tổng quát người dùng
        public IActionResult UsersOverview()
        {
            if (HttpContext.Session.GetInt32("Role_Id") <= 3)
            {
                return View(_context.Users);
            }
            else
            {
                return RedirectToAction("Login");

            }
        }

        #region Nhóm trang sản phẩm
        // Trang tổng quát sản phẩm
        public IActionResult ProductsOverview()
        {
            if (HttpContext.Session.GetInt32("Role_Id") <= 3)
            {

                return View(_context.Products.OrderByDescending(p => p.Id));
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        
        #region Sản phẩm
        // Thêm sản phẩm
        public IActionResult ProductNew()
        {
            // Tạo slug mới
            var new_slug = new Slug();

            new_slug.Url = DateTime.Now.ToString();
            new_slug.DateCreate = DateTime.Now;
            new_slug.DateModify = DateTime.Now;
            _context.Slugs.Add(new_slug);
            _context.SaveChanges();

            ProductNewViewModel viewmodel = new ProductNewViewModel()
            {
                Product = new Product()
                {
                    Slug_Id = _context.Slugs.LastOrDefault().Id,
                    Admin_Id = (int)HttpContext.Session.GetInt32("Admin_Id")
                },
                ProductBrands = _context.ProductBrands.ToList(),
                ProductTypes = _context.ProductTypes.ToList()
            };

            return View(viewmodel);
        }

        [HttpPost]
        public IActionResult ProductNew(ProductNewViewModel viewmodel)
        {
            Product new_product = viewmodel.Product;
            new_product.Thumbnail = "#";

            // Tải hình ảnh sản phẩm lên thư mục wwwroot/uploads
            if (viewmodel.Thumbnail != null)
            {
                new_product.Thumbnail = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                string uniqueName = new_product.Thumbnail; // Tạo tên hình ảnh theo chuỗi ngày tháng lúc đăng ảnh
                string newpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads"); // Trỏ đường dẫn đến thư mục wwwroot/uploads
                newpath = Path.Combine(newpath, uniqueName); // Trỏ đường dẫn đến tên hình ảnh
                newpath = newpath + Path.GetExtension(viewmodel.Thumbnail.FileName); // Gắn đuôi (loại file) cho hình
                viewmodel.Thumbnail.CopyTo(new FileStream(newpath, FileMode.Create)); // Copy hình từ nguồn sang wwwroot/uploads
                new_product.Thumbnail += Path.GetExtension(viewmodel.Thumbnail.FileName);
            }

            Slug edit_slug = _context.Slugs.Where(s => s.Id == new_product.Slug_Id).FirstOrDefault();
            edit_slug.Url = StaticClass.ToUrlFriendly(new_product.Name);

      

            _context.Products.Add(new_product);
            _context.SaveChanges();
            return RedirectToAction("ProductsOverview", "Admin");
        }

        [HttpGet]
        public IActionResult ProductDetail(int id)
        {
            Product detail = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            if (detail != null)
            {
                ProductDetailViewModel vm = new ProductDetailViewModel()
                {
                    Product     = detail,
                    BrandName   = _context.ProductBrands.Where(p => p.Id == detail.ProductBrand_Id).FirstOrDefault().Name,
                    ProductType = _context.ProductTypes.Where(p => p.Id == detail.ProductType_Id).FirstOrDefault().Type,
                    AdminUsername = _context.Admins.Where(p => p.Id == detail.Admin_Id).FirstOrDefault().Username
                };
                return View(vm);
            }
            else
            {
                return RedirectToAction("ProductsOverview","Admin");
            }
        }

        [HttpGet]
        public IActionResult ProductEdit(int id)
        {
            Product edit = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            if (edit != null)
            {
                ProductEditViewModel vm = new ProductEditViewModel()
                {
                    Product = edit,
                    ProductBrands = _context.ProductBrands.OrderBy(p => p.Name).ToList(),
                    ProductTypes  = _context.ProductTypes.OrderBy(p => p.Type).ToList()
                };
                return View(vm);
            }
            else
            {
                return RedirectToAction("ProductsOverview","Admin");
            }
        }

        [HttpPost]
        public IActionResult ProductEdit(ProductEditViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Product data = vm.Product;
                Product up = _context.Products.Where(p => p.Id == data.Id).FirstOrDefault();

                up.Name            = data.Name;
                up.Description     = data.Description;
                up.ProductBrand_Id = data.ProductBrand_Id;
                up.ProductType_Id  = data.ProductType_Id;
                up.Description     = data.Description;
                up.Price           = data.Price;
                up.Saleoff         = data.Saleoff;
                up.DateModify      = data.DateModify;
                up.Instore         = data.Instore;
                up.BuyPoints       = data.BuyPoints;

                if (vm.Thumbnail != null)
                {
                    // Xóa ảnh cũ
                    string old_image = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","uploads",data.Thumbnail);
                    if (System.IO.File.Exists(old_image))
                    {
                        System.IO.File.Delete(old_image);
                    }
            
                    // Lưu ảnh mới
                    string rename = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + Path.GetExtension(vm.Thumbnail.FileName);
                    string new_image = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","uploads", rename);
                    vm.Thumbnail.CopyTo(new FileStream(new_image,FileMode.Create));
                    up.Thumbnail = rename;
                }
                _context.SaveChanges();
                return View(
                    new ProductEditViewModel()
                    {
                        Product       = _context.Products.Where(p => p.Id == vm.Product.Id).FirstOrDefault(),
                        ProductBrands = _context.ProductBrands.OrderBy(p => p.Name).ToList(),
                        ProductTypes  = _context.ProductTypes.OrderBy(p => p.Type).ToList()
                    }
                );
            }
            else
            {
                return View(
                    new ProductEditViewModel()
                    {
                        Product = vm.Product,
                        ProductBrands = _context.ProductBrands.OrderBy(p => p.Name).ToList(),
                        ProductTypes  = _context.ProductTypes.OrderBy(p => p.Type).ToList()
                    }
                );
            }
        }

        [HttpGet]
        public IActionResult ProductDelete(int id)
        {
            Product delete = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            if (delete != null)
            {
                // Xóa hình ảnh đại diện trong thư mục wwwroot/uploads
                string path_delete = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","uploads",delete.Thumbnail);
                
                // Phải sử dụng System.IO thì mới xài được File
                if (System.IO.File.Exists(path_delete))
                {
                    System.IO.File.Delete(path_delete);
                }
                _context.Products.Remove(delete);
                _context.SaveChanges();
            }
            return RedirectToAction("ProductsOverview","Admin");
        }
        #endregion
        // Trang tổng quát các nhãn hàng
        public IActionResult ProductBrandsOverview()
        {
            ProductBrandsViewModel viewmodel = new ProductBrandsViewModel()
            { ProductBrands = _context.ProductBrands.ToList() };
            return View(viewmodel);
        }
        // Trang tổng quát loại sản phẩm
        public IActionResult ProductTypes()
        {
            if (HttpContext.Session.GetInt32("Role_Id") <= 3)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");

            }
        }
        #endregion


        // Trang tổng quan quản trị
        public IActionResult AdminsOverview()
        {
            if (HttpContext.Session.GetInt32("Role_Id") <= 3)
            {
                return View(_context.Admins);
            }
            else
            {
                return RedirectToAction("Login");

            }

        }


        // Trang thống kê
        public IActionResult Report()
        {
            if (HttpContext.Session.GetInt32("Role_Id") <= 3)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");

            }
        }

        // Trang cài đặt
        public IActionResult Setting()
        {
            if (HttpContext.Session.GetInt32("Role_Id") <= 3)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");

            }
        }

        // them xoa sua admin Suong
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // GET: Admins/Create
        public IActionResult Create()
        {
            ViewData["Role_Id"] = new SelectList(_context.Roles, "Id", "Name");
            return View();
        }

        // POST: Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Role_Id,Username,Password,Email,DateCreate,DateModify")] Admin admin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(admin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Role_Id"] = new SelectList(_context.Roles, "Id", "Name", admin.Role_Id);
            return View(admin);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins.FindAsync(id);
            if (admin == null)
            {
                return NotFound();
            }
            ViewData["Role_Id"] = new SelectList(_context.Roles, "Id", "Name", admin.Role_Id);
            return View(admin);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Role_Id,Username,Password,Email,DateCreate,DateModify")] Admin admin)
        {
            if (id != admin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(admin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminExists(admin.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Role_Id"] = new SelectList(_context.Roles, "Id", "Name", admin.Role_Id);
            return View(admin);
        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admin = await _context.Admins
                .Include(a => a.Role)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (admin == null)
            {
                return NotFound();
            }

            return View(admin);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admin = await _context.Admins.FindAsync(id);
            _context.Admins.Remove(admin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminExists(int id)
        {
            return _context.Admins.Any(e => e.Id == id);
        }
    }
}