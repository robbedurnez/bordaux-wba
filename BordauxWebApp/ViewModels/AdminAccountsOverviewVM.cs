using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BordauxWebApp.ViewModels
{
    public class AdminAccountsOverviewVM
    {
        public string Id { get; set; }
        public string ProfilePicturePath { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<string> Roles { get; set; }
    }
}
