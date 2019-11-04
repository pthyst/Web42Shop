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
        public IActionResult Index(int id)
        {
            //int p = (!page.HasValue) ? 0 : page.Value;
            int p = (id==null) ? 0 : id;
            HomeProductsViewModel homeProducts = new HomeProductsViewModel{
                Count = GetCountProducts(),
                ItemProducts = GetAllProducts(p)
            };
            return View(homeProducts);
        }
        public IActionResult Single()
        {
            return View();
        }



        //hàm cho phần phân trang
        private int GetCountProducts(){
            int sl = _context.Products.Count();
            return sl;
        }
        private List<ItemProductsViewModel> GetAllProducts(int page){
            Console.WriteLine(page);
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
            pro = query.Skip(page*12).Take(12).ToList();
            return pro;
        }
    }
}