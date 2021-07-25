using System;
using System.Collections.Generic;

namespace BettingAPI.Dtos
{
    public class EventDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public List<ConfrontationDto> Confrontations { get; set; }
    }
}
