using System;
using System.Collections.Generic;

namespace BordauxWebApp.ViewModels
{
    public class ActsUpdateActVM
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<ActsEventActVM> Events { get; set; }
    }
}
