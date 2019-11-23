using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web42Shop.Data;
using Web42Shop.ViewModels;

namespace website.Controllers
{
    public class CartController : Controller
    {
        private readonly Web42ShopDbContext _context;


        public CartController(Web42ShopDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            UserCartViewModel viewModel = new UserCartViewModel
            {
                ProductTypes = _context.ProductTypes.ToList(),
            };
            return View(viewModel);
        }
        public void addItem()
        {
            //if()
        }
    }
}