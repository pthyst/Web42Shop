using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web42Shop.Models;

namespace Web42Shop.ViewModels
{
    public class AdminProductBrandEditViewModel
    {
        public ProductBrand ProductBrand {get;set;}
        public IEnumerable<ProductBrand> ProductBrands { get; set; }
        public IEnumerable<Product> Products {get;set;}
        public IEnumerable<Slug> Slugs {get;set;}
        public string Slug {get;set;}
    }
}