using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web42Shop.Models;

namespace Web42Shop.ViewModels
{
    public class AdminOrdersOverviewViewModel
    {
        public IEnumerable<Order> Orders {get;set;}
        public IEnumerable<OrderStatus> OrderStatus {get;set;}
    }
}