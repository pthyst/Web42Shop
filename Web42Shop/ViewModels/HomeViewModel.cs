using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web42Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<ItemProductsViewModel> NewProducts { get; set; }
        public IEnumerable<ItemProductsViewModel> ViewMoreProduct { get; set; }
    }
}
