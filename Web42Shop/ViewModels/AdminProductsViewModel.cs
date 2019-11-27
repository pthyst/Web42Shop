using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web42Shop.Models;

namespace Web42Shop.ViewModels
{
    public class AdminProductsViewModel
    {
        public IEnumerable<Product> Products {get;set;}
    }
}