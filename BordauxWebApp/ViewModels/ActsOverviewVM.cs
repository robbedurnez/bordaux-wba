using System;
using System.Collections.Generic;

namespace BordauxWebApp.ViewModels
{
    public class ActsOverviewVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<string> Events { get; set; }
    }
}
