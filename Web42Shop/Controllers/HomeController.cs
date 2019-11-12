using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web42Shop.Data;
using Web42Shop.Models;
using Web42Shop.ViewModels;

namespace Web42Shop.Controllers
{
    public class HomeController : Controller
    {
        private Web42ShopDbContext _context;
        public HomeController(Web42ShopDbContext context)
        {
            _context = context;
        }
        // Trang chủ
        public IActionResult Index()
        {
            HomeViewModel home = new HomeViewModel()
            {
                NewProducts = GetListItemProducts(0),
                ViewMoreProduct = GetListItemProducts(1)
            };
            return View(home);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        ///
        private List<ItemProductsViewModel> GetListItemProducts(int type)
        {
            List<ItemProductsViewModel> products = new List<ItemProductsViewModel>();
            if(type == 0)
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
                products = query.Skip(0).Take(8).ToList();
            }
            else if (type == 1)
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
                products = query.Skip(0).Take(8).ToList();
            }
            return products;
        }
    }
}
