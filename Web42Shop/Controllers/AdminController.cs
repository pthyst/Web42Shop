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


        // Trang phân công
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("Admin_ID") == 1)
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
            HttpContext.Session.Remove("Admin_ID");
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
            else if (Auth.Role_Id == 1)
            {
                HttpContext.Session.SetInt32("Admin_ID", Auth.Role_Id);

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
            if (HttpContext.Session.GetInt32("Admin_ID") == 1)
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
            if (HttpContext.Session.GetInt32("Admin_ID") == 1)
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
            if (HttpContext.Session.GetInt32("Admin_ID") == 1)
            {

                return View(_context.Products);
            }
            else
            {
                return RedirectToAction("Login");

            }
        }
        [HttpGet]
        // GET: /Link/

        // Trang thêm sản phẩm
        public IActionResult ProductsNew()
        {
            // Tạo slug mới
            var new_slug = new Slug();

            new_slug.Url = DateTime.Now.ToString();
            new_slug.DateCreate = DateTime.Now;
            new_slug.DateModify = DateTime.Now;
            _context.Slugs.Add(new_slug);
            _context.SaveChanges();

            ProductsNewViewModel viewmodel = new ProductsNewViewModel()
            {
                Product = new Product()
                {
                    Slug_Id = _context.Slugs.LastOrDefault().Id,
                    Admin_Id = _context.Admins.LastOrDefault().Id
                },
                ProductBrands = _context.ProductBrands.ToList(),
                ProductTypes = _context.ProductTypes.ToList()
            };

            return View(viewmodel);
        }
        // Lấy dữ liệu từ form và đưa vào database
        [HttpPost]
        public IActionResult ProductsCreate(ProductsNewViewModel viewmodel)
        {
            // Thêm sản phẩm vào database

            Product new_product = viewmodel.Product;
            new_product.Thumbnail = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            _context.Products.Add(new_product);
            _context.SaveChanges();

            // Tải hình ảnh sản phẩm lên thư mục wwwroot/uploads
            if (viewmodel.Thumbnail != null)
            {
                string uniqueName = new_product.Thumbnail; // Tạo tên hình ảnh theo chuỗi ngày tháng lúc đăng ảnh
                string newpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads"); // Trỏ đường dẫn đến thư mục wwwroot/uploads
                newpath = Path.Combine(newpath, uniqueName); // Trỏ đường dẫn đến tên hình ảnh
                newpath = newpath + Path.GetExtension(viewmodel.Thumbnail.FileName); // Gắn đuôi (loại file) cho hình
                viewmodel.Thumbnail.CopyTo(new FileStream(newpath, FileMode.Create)); // Copy hình từ nguồn sang wwwroot/uploads
            }

            return RedirectToAction("ProductsOverview", "Admin");
        }

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
            if (HttpContext.Session.GetInt32("Admin_ID") == 1)
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
            if (HttpContext.Session.GetInt32("Admin_ID") == 1)
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
            if (HttpContext.Session.GetInt32("Admin_ID") == 1)
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
            if (HttpContext.Session.GetInt32("Admin_ID") == 1)
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