namespace Models.Hotels
{
    public class GetHotelsEvent : EventModel
    {
        public String Country { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
