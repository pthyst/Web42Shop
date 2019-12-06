using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web42Shop.Data;
using Web42Shop.Models;
using Web42Shop.ViewModels;

namespace Web42Shop.ViewModels
{
    public class UserMyOrderDetailViewModel
    {
        public UserMyOrderViewModel MyOrderViewModel {get;set;}
        public IEnumerable<UserMyOrderViewModel> MyOrderViewModels {get;set;}
        public IEnumerable<ProductType> ProductTypes {get;set;}
    }
}
