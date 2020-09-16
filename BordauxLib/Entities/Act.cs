using System;
using System.Collections.Generic;

namespace BordauxLib.Entities
{
    public class Act
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<EventAct> Events { get; set; }
    }
}
