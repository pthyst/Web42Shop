using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web42Shop.Models;

namespace Web42Shop.ViewModels
{
    public class CartViewModel
    {
        public IEnumerable<ProductType> ProductTypes { get; set; }
    }
}