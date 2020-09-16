using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BordauxWebApp.ViewModels
{
    public class AdminCreateRoleVM
    {
        [Required(ErrorMessage = "Role name is required.")]
        [Display(Name = "Role name:")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
    }
}
