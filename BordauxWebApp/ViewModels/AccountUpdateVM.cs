using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BordauxWebApp.ViewModels
{
    public class AccountUpdateVM
    {
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

        [Display(Name = "Old password:")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Display(Name = "Password:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm password:")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Password and confirm password do not match")]
        public string ConfirmPassword { get; set; }

        public string ProfilePicturePath { get; set; }
    }
}
