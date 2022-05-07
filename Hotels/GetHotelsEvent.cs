namespace Models.Hotels
{
    public class GetHotelsEvent : EventModel
    {
        public String Country { get; set; }
        public String Attraction { get; set; }

        public GetHotelsEvent(string country, string attraction) : base()
        {
            Country = country;
            Attraction = attraction;
        }
    }
}
