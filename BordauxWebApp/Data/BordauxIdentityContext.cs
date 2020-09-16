using BordauxLib.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BordauxWebApp.Data
{
    public class BordauxIdentityContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> ApplicationUsers;

        public BordauxIdentityContext(DbContextOptions<BordauxIdentityContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            IdentitySeeder.Seed(builder);
        }
    }
}
