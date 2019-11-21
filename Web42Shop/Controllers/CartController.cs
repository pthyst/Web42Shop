using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web42Shop.Models;
using Web42Shop.ViewModels;
using Web42Shop.Data;

namespace Web42Shop.Controllers
{
    public class CartController : Controller
    {
        private Web42ShopDbContext _context;
        public CartController(Web42ShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CartViewModel vm = new CartViewModel()
            {
                ProductTypes = _context.ProductTypes.ToList()
            };
            return View(vm);
        }
    }
}