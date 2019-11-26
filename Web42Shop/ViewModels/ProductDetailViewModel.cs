using Web42Shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Web42Shop.ViewModels
{
    public class ProductDetailViewModel
    {
        public Product Product { get; set; }
        public string BrandName {get;set;}
        public string ProductType {get;set;}
        public string AdminUsername {get;set;}
    }
}
