using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BordauxWebApp.ViewModels
{
    public class AdminUpdateRoleVM
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Role name is required.")]
        public string Name { get; set; }

        public List<AdminUserRoleVM> ApplicationUsers { get; set; }
    }
}
