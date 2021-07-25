using System;

namespace BettingAPI.Dtos
{
    public class CreateEventDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime DateTo { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
    }
}
