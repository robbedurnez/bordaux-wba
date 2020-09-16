using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BordauxWebApp.ViewModels
{
    public class AdminUpdateUserVM
    {
        public string Id { get; set; }

        [Display(Name = "First name:")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Display(Name = "Last name:")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Display(Name = "Profile image")]
        public IFormFile ProfileImage { get; set; }

        [Display(Name = "Email address:")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Email address must be valid")]
        public string Email { get; set; }

        public string ProfilePicturePath { get; set; }

        [Display(Name = "Roles:")]
        public List<AdminUserRoleVM> Roles { get; set; }
    }
}
