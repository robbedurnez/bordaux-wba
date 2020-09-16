using BordauxLib.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace BordauxWebApp.Data
{
    public class IdentitySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            var user1 = new ApplicationUser()
            {
                UserName = "dwight.senaeve@student.howest.be",
                NormalizedUserName = "DWIGHT.SENAEVE@STUDENT.HOWEST.BE",
                FirstName = "Dwight",
                LastName = "Senaeve",
                Email = "dwight.senaeve@student.howest.be",
                NormalizedEmail = "DWIGHT.SENAEVE@STUDENT.HOWEST.BE",
                SecurityStamp = Guid.NewGuid().ToString("B")
            };
            var user2 = new ApplicationUser()
            {
                UserName = "robbe.durnez@student.howest.be",
                NormalizedUserName = "ROBBE.DURNEZ@STUDENT.HOWEST.BE",
                FirstName = "Robbe",
                LastName = "Durnez",
                Email = "robbe.durnez@student.howest.be",
                NormalizedEmail = "ROBBE.DURNEZ@STUDENT.HOWEST.BE",
                SecurityStamp = Guid.NewGuid().ToString("B")
            };
            var user3 = new ApplicationUser()
            {
                UserName = "john.doe@student.howest.be",
                NormalizedUserName = "JOHN.DOE@STUDENT.HOWEST.BE",
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@student.howest.be",
                NormalizedEmail = "JOHN.DOE@STUDENT.HOWEST.BE",
                SecurityStamp = Guid.NewGuid().ToString("B")
            };
            var roleAdmin = new IdentityRole() { Name = "Admin", NormalizedName = "ADMIN" };
            var rolePromotor = new IdentityRole() { Name = "Promotor", NormalizedName = "PROMOTOR" };
            var roleUser = new IdentityRole() { Name = "User", NormalizedName = "USER" };

            user1.PasswordHash = passwordHasher.HashPassword(user1, "dwightsenaeve");
            user2.PasswordHash = passwordHasher.HashPassword(user2, "robbedurnez");
            user3.PasswordHash = passwordHasher.HashPassword(user3, "johndoe");

            modelBuilder.Entity<IdentityRole>().HasData(
                roleAdmin,
                rolePromotor,
                roleUser
            );

            modelBuilder.Entity<ApplicationUser>().HasData(
                user1,
                user2,
                user3
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = roleAdmin.Id, UserId = user1.Id },
                new IdentityUserRole<string>() { RoleId = roleAdmin.Id, UserId = user2.Id },
                new IdentityUserRole<string>() { RoleId = roleUser.Id, UserId = user3.Id }
            );
        }
    }
}