using BordauxLib.Entities;
using System;
using System.Collections.Generic;

namespace BordauxWebApp.ViewModels
{
    public class EventsDetailsVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AddressLine { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public List<Act> Acts { get; set; }
        public string Promotor { get; set; }
        public string PromotorId { get; set; }
        public string LoggedInUserId { get; set; }
    }
}
