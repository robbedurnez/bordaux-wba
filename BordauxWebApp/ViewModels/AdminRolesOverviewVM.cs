using BordauxLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BordauxWebApp.ViewModels
{
    public class AdminRolesOverviewVM
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
