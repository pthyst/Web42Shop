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

namespace Web42Shop.Controllers
{
    public class AdminController : Controller
    {
        private readonly Web42ShopDbContext _context;
        private readonly IHostingEnvironment _hostingEnviroment;

        
        public AdminController(Web42ShopDbContext context,IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnviroment = hostingEnvironment;
        }
  

        // Trang phân công
        public IActionResult Index()
        {
            return View();
        }
        

        // Trang đăng nhập
        public IActionResult Login()
        {
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
            else if(Auth.Role_Id ==1)
            {

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
            return View();
        }

        // Trang tổng quát người dùng
        public IActionResult UsersOverview()
        {
            return View();
        }

        #region Nhóm trang sản phẩm
        // Trang tổng quát sản phẩm
        public IActionResult ProductsOverview()
        {
            return View();
        }
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
                    Slug_Id = _context.Slugs.LastOrDefault().Id
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
                string newpath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","uploads"); // Trỏ đường dẫn đến thư mục wwwroot/uploads
                newpath = Path.Combine(newpath,uniqueName); // Trỏ đường dẫn đến tên hình ảnh
                newpath = newpath+Path.GetExtension(viewmodel.Thumbnail.FileName); // Gắn đuôi (loại file) cho hình
                viewmodel.Thumbnail.CopyTo(new FileStream(newpath,FileMode.Create)); // Copy hình từ nguồn sang wwwroot/uploads
            }

            return RedirectToAction("ProductsOverview","Admin");
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
            return View();
        }
        #endregion


        // Trang tổng quan quản trị
        public IActionResult AdminsOverview()
        {
            return View();
        }

        // Trang thống kê
        public IActionResult Report()
        {
            return View();
        }

        // Trang cài đặt
        public IActionResult Setting()
        {
            return View();
        }
    }
}