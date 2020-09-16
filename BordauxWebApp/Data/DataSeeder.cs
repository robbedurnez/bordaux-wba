using BordauxLib.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace BordauxWebApp.Data
{
    public class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Acts
            var actId1 = Guid.NewGuid();
            var actId2 = Guid.NewGuid();
            var actId3 = Guid.NewGuid();

            var act1 = new Act() { Name = "Bordaux", Id = actId1 };
            var act2 = new Act() { Name = "Justified", Id = actId2 };
            var act3 = new Act() { Name = "DwightLight", Id = actId3 };

            modelBuilder.Entity<Act>().HasData(
                act1,
                act2,
                act3
            );

            // Events
            var eventId1 = Guid.NewGuid();
            var eventId2 = Guid.NewGuid();
            var eventId3 = Guid.NewGuid();
            var promotor = new Promotor()
            {
                Id = "a11f645a-a580-47c4-87fb-6a57b8e16f68",
                Email = "robbe.durnez@student.howest.be"
            };

            modelBuilder.Entity<Promotor>()
                 .HasData(new
                 {
                     Id = "a11f645a-a580-47c4-87fb-6a57b8e16f68",
                     Email = "robbe.durnez@student.howest.be"
                 });

            modelBuilder.Entity<Event>()
                .HasData(
                new
                {
                    Id = eventId1,
                    Name = "2Fish invites Bordaux",
                    City = "Torhout",
                    DateCreated = DateTime.Now,
                    StartDate = new DateTime(2019, 6, 29),
                    EndDate = new DateTime(2019, 6, 30),
                    StartTime = new TimeSpan(18, 0, 0),
                    EndTime = new TimeSpan(4, 0, 0),
                    AddressLine = "Stationsstraat 19",
                    PostalCode = 8840,
                    PromotorId = promotor.Id
                },
                new
                {
                    Id = eventId2,
                    Name = "Club NEO invites Bordaux",
                    City = "Brugge",
                    DateCreated = DateTime.Now,
                    StartDate = new DateTime(2019, 11, 24),
                    EndDate = new DateTime(2019, 11, 25),
                    StartTime = new TimeSpan(23, 0, 0),
                    EndTime = new TimeSpan(5, 0, 0),
                    AddressLine = "Kuipersstraat 13",
                    PostalCode = 8840,
                    PromotorId = promotor.Id
                },
                new
                {
                    Id = eventId3,
                    Name = "2Fish invites Bordaux pt 2",
                    City = "Torhout",
                    DateCreated = DateTime.Now,
                    StartDate = new DateTime(2019, 7, 29),
                    EndDate = new DateTime(2019, 7, 30),
                    StartTime = new TimeSpan(18, 0, 0),
                    EndTime = new TimeSpan(4, 0, 0),
                    AddressLine = "Stationsstraat 10",
                    PostalCode = 8840,
                    PromotorId = promotor.Id
                }
                );
        }
    }
}
