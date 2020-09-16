using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BordauxLib.Entities
{
    public class ApplicationUser : IdentityUser 
    {
        [MaxLength(42)]
        public string FirstName { get; set; }
        [MaxLength(42)]
        public string LastName { get; set; }
        public string ProfilePicturePath { get; set; }
    }
}
