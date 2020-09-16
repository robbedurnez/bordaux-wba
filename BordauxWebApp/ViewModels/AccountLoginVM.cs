using System;
using System.ComponentModel.DataAnnotations;

namespace BordauxWebApp.ViewModels
{
    public class AccountLoginVM
    {
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address:")]
        [EmailAddress(ErrorMessage = "Email address must be valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}