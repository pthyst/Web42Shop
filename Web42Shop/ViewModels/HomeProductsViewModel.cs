using Web42Shop;
using Web42Shop.Data;
using Web42Shop.Models;
using System.Collections.Generic;
namespace Web42Shop.ViewModels
{
    public class HomeProductsViewModel
    {
        public int Count {get; set;}
        public IEnumerable<ItemProductsViewModel> ItemProducts {get;set;}

    }
}