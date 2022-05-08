namespace Models.Offers
{
    public class GetTripsFromDatabaseEvent : EventModel
    {
        public string? Destination { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
