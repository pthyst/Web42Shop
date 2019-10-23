using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web42Shop.Models;

namespace Web42Shop.Controllers
{
    public class AdminController : Controller
    {
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