using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BordauxWebApp.ViewModels
{
    public class AdminUserRoleVM
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public bool IsChecked { get; set; }
    }
}
