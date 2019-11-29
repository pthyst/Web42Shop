using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Web42Shop.Data;
using Web42Shop.Models;

namespace Web42Shop.ViewModels
{
    public class UserRegisterViewModel
    {
        public User User { get;set;}

        // Dành cho thanh menu 
        public IEnumerable<ProductType> ProductTypes {get;set;}
    }
}
