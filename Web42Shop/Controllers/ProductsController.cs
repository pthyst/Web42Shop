using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web42Shop.Models;
using Web42Shop.ViewModels;
using Microsoft.EntityFrameworkCore;
using Web42Shop.Data;

namespace Web42Shop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly Web42ShopDbContext _context;
        public static Boolean f = false;

        public ProductsController(Web42ShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? page)
        {
            int p = (!page.HasValue) ? 1 : page.Value;
            if (page <= 0) return NotFound();
            HomeProductsViewModel homeProducts = new HomeProductsViewModel
            {
                CurrentPage = p,
                TotalPage = GetTotalPage(),
                ItemProducts = GetAllProducts(p)
            };
            return View(homeProducts);
        }
        public IActionResult Single()
        {
            return View();
        }



        //hàm cho phần phân trang
        private int GetTotalPage(){
            int sl = _context.Products.Count();
            int total = (sl % 8 == 0) ? (sl / 8) : (sl / 8) + 1; 
            return total;
        }
        private List<ItemProductsViewModel> GetAllProducts(int page){
            page--;
            List<ItemProductsViewModel> pro = new List<ItemProductsViewModel>();
            var query = (from p in _context.Products 
                    orderby p.Name
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