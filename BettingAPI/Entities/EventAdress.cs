namespace BettingAPI.Entities
{
    public class EventAdress
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public virtual Event Event { get; set; }
    }
}
