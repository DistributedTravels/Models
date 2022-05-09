namespace Models.Hotels
{
    public class GetHotelsEvent : EventModel
    {
        public String Country { get; set; }


        public GetHotelsEvent(
            string country) : base()
        {
            Country = country;
        }
    }
}
