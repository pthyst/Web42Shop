using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Web42Shop.Models;
using Web42Shop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Web42Shop.ViewModels;



namespace Web42Shop.Controllers
{
    public class AdminController : Controller
    {
        private readonly Web42ShopDbContext _context;
        public static Boolean f = false;

        public AdminController(Web42ShopDbContext context)
        {
            _context = context;
        }
        // Trang phân công
      
        

        // Trang đăng nhập
        public IActionResult Login()
        {
            f = false;
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {

            var Auth = _context.Admins.Where(ad => ad.Username == admin.Username && ad.Password == admin.Password).FirstOrDefault();
            if (Auth == null)
            {
                @ViewBag.error = "Please Enter Correct Username And Password";
                return View("Login");
            }
            else if(Auth.Role_Id ==1)
            {
                f = true;
                return View("Index");
            }
            else
            {
               
               
                //HttpContext.Current.Session["Admin_ID"] = Auth.Id;
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
           
            ProductsNewViewModel viewmodel = new ProductsNewViewModel()
            {
                Product = new Product(),
                ProductBrands = _context.ProductBrands.ToList(),
                ProductTypes = _context.ProductTypes.ToList()
            };

            return View(viewmodel);
        }
        // Lấy dữ liệu từ form và đưa vào database
        [HttpPost]
        public IActionResult ProductsCreate(Product data)
        {
            Product newproduct = new Product()
            {
                ProductBrand_Id = data.ProductBrand_Id,
                ProductType_Id = data.ProductType_Id,
                Slug_Id = data.Slug_Id,
                Admin_Id = data.Admin_Id,
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                Thumbnail = data.Thumbnail,
                Saleoff = data.Saleoff,
                Instore = data.Instore,
                Stars = data.Stars,
                BuyPoints = data.BuyPoints
            };
            _context.Products.Add(newproduct);
            _context.SaveChanges();
            return RedirectToAction("ProductsOverview","Admin");
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
        public IActionResult Index()
        {
            if (f)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
               
            }
        }
        
    }
}