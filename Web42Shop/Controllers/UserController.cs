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
    public class UserController : Controller
    {
        private readonly Web42ShopDbContext _context;

        public UserController(Web42ShopDbContext context)
        {
            _context = context;
        }

        #region Functions
        // Kiểm tra xem có đăng nhập hay chưa
        public bool IsLogedIn()
        {
            if (HttpContext.Session.GetInt32("IdTaiKhoan") != null && HttpContext.Session.GetInt32("TenTaiKhoan") != null)
            {
                return true;
            }
            return false;
        }

        // Kiểm tra email với mật khẩu
        public bool EmailLogin(string email,string password)
        {
            User login = _context.Users.Where(u => u.Email == email).FirstOrDefault();
            if (login == null){ return false;}
            else if (login.Password != password){ return false;}
            else {return true;}
        }

        // Kiểm tra số điện thoại với mật khẩu
        public bool PhoneNumberLogin(string phonenumber,string password)
        {
            User login = _context.Users.Where(u => u.PhoneNumber == phonenumber).FirstOrDefault();
            if (login == null){ return false;}
            else if (login.Password != password){ return false;}
            else {return true;}
        }

        #endregion
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Information()
        {
            return View();
        }

        public IActionResult MyOrder()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View(
                new UserRegisterViewModel()
                {
                    User = new User(){
                        Role_Id  = 4 // Role_Id của user là 4
                    },
                    ProductTypes = _context.ProductTypes.ToList()
                }
            );
        }

        [HttpPost]
        public IActionResult Register(UserRegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(vm.User);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                return View(
                    new UserRegisterViewModel()
                    {
                        User = vm.User,
                        ProductTypes = _context.ProductTypes.ToList()
                    }
                );
            }
        }

        public IActionResult Login()
        {
            return View(
                new UserLoginViewModel()
                {
                    ProductTypes = _context.ProductTypes.ToList()
                }
            );
        }

        [HttpPost]
        public IActionResult Login(UserLoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                string u = vm.Username;
                string p = vm.Password;

                if (EmailLogin(u,p) == true || PhoneNumberLogin(u,p) == true)
                {
                    User data = _context.Users.Where(us => us.Email == u).FirstOrDefault();
                    if (data == null) { data =  _context.Users.Where(us => us.PhoneNumber == u).FirstOrDefault();}

                    string displayname = data.NameLast;
                    if (data.NameMiddle != null) { displayname += " " + data.NameMiddle + " ";}
                    displayname += " " + data.NameFirst;

                    int id = data.Id;

                    HttpContext.Session.SetInt32("IdTaiKhoan",id);
                    HttpContext.Session.SetString("TenTaiKhoan",displayname);

                    return RedirectToAction("Index","Home");
                }
            }
            
            return View(
                new UserLoginViewModel()
                {
                    Username = vm.Username,
                    Password = vm.Password,
                    ProductTypes = _context.ProductTypes.ToList()
                }
            );
        }

        public IActionResult Logout()
        {
            if (IsLogedIn() == true)
            {
                HttpContext.Session.Remove("IdTaiKhoan");
                HttpContext.Session.Remove("TenTaiKhoan");
            }
            return RedirectToAction("Login");
        }
    }
}