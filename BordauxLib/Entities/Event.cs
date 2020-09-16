using System;
using System.Collections.Generic;

namespace BordauxLib.Entities
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string AddressLine { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public List<EventAct> Acts { get; set; }
        public Promotor Promotor { get; set; }
    }
}
