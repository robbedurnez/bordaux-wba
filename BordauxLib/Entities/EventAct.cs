using System;

namespace BordauxLib.Entities
{
    public class EventAct
    {
        public Event Event { get; set; }
        public Guid EventId { get; set; }
        public Act Act { get; set; }
        public Guid ActId { get; set; }
    }
}
