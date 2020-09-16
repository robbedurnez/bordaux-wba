using BordauxLib.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BordauxWebApp.ViewModels
{
    public class EventsCreateEventVM
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Event name is required.")]
        public string Name { get; set; }

        [Display(Name = "Street + number:")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Event name is required.")]
        public string AddressLine { get; set; }

        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage = "Postal code is required.")]
        public int PostalCode { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        public DateTime DateCreated { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Start date is required.")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "End date is required.")]
        public DateTime EndDate { get; set; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Start time is required.")]
        public TimeSpan StartTime { get; set; }

        [DataType(DataType.Time)]
        [Required(ErrorMessage = "End time is required.")]
        public TimeSpan EndTime { get; set; }

        public ApplicationUser Promotor { get; set; }

        public List<EventsActVM> Acts { get; set; }

    }
}
