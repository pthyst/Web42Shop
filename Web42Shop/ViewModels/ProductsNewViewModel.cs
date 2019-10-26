using Web42Shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Web42Shop.ViewModels
{
    public class ProductsNewViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<ProductBrand> ProductBrands { get; set; }
        public IEnumerable<ProductType> ProductTypes { get; set; }
    }
}