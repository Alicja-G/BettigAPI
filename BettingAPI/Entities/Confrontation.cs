using System;

namespace BettingAPI.Entities
{
    public class Confrontation
    {
        public int Id { get; set; }
        public string FirstTeam { get; set; }
        public string SecondTeam { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }
        public bool IsOngoing => EndDate == null;
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
