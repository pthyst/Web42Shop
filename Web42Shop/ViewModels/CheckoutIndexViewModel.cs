using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web42Shop.Models;

namespace Web42Shop.ViewModels
{
    public class CheckoutIndexViewModel
    {
        public List<OrderDetail> OrderDetails {get;set;}
        public List<Product> Products{get;set;}
        public IEnumerable<ProductType> ProductTypes {get;set;}
    }
}