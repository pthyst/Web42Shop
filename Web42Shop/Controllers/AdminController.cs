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
using Web42Shop.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Web42Shop.Controllers
{
    public class AdminController : Controller
    {
        private readonly Web42ShopDbContext _context;
        public AdminController(Web42ShopDbContext context)
        {
            _context = context;
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
    }
}