using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web42Shop.Models;

namespace Web42Shop.ViewModels
{
    public class AdminAdminNewViewModel
    {
        public Admin Admin {get;set;}
        public IEnumerable<Role> Roles {get;set;}
    }
}