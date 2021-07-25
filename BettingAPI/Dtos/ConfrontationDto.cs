using System;

namespace BettingAPI.Dtos
{
    public class ConfrontationDto
    {
        public int Id { get; set; }
        public string FirstTeam { get; set; }
        public string SecondTeam { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsOngoing => EndDate == null;
    }
}
