using System;
using System.Collections.Generic;

namespace BettingAPI.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int EventAdressId { get; set; }
        public virtual EventAdress EventAdress { get; set; }
        public virtual List<Confrontation> Confrontations { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }

    }
}
