using System.Collections.Generic;

namespace BordauxLib.Entities
{
    public class Promotor
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public List<Event> Events { get; set; }
    }
}