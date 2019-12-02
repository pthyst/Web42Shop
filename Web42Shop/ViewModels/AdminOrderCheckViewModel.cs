using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web42Shop.Models;

namespace Web42Shop.ViewModels
{
    public class AdminOrderCheckViewModel
    {
        public Order Order {get;set;}
        public IEnumerable<OrderDetail> OrderDetails {get;set;}
        public IEnumerable<OrderStatus> OrderStatus {get;set;}
        public List<Product> Products {get;set;}
    }
}