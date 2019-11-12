using Web42Shop;
using Web42Shop.Data;
using Web42Shop.Models;
using System.Collections.Generic;
namespace Web42Shop.ViewModels
{
    public class ListItemProductsViewModel
    {
        public string Value { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPage { get; set; }
        public IEnumerable<ItemProductsViewModel> ItemProducts { get; set; }
        public IEnumerable<ProductType> ProductTypes { get; set; }

    }
}