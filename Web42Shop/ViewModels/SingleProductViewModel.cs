using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web42Shop.Models;

namespace Web42Shop.ViewModels
{
    public class SingleProductViewModel
    {
        public Product SingleProduct { get; set; }
        public string ProductType { get; set; }
        public string ProductBrand { get; set; }
        public string Url { get; set; }
        public IEnumerable<ItemProductsViewModel> ProductsSimilar { get; set; }
        public PerformCommentsViewModel ProductComments { get; set; }
        public IEnumerable<ProductType> ProductTypes { get; set; }
    }
}
