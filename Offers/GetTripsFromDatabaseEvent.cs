namespace Models.Offers
{
    public class GetTripsFromDatabaseEvent : EventModel
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfPeople { get; set; }
        public int Adults { get; set; }
        public int ChildrenUnder3 { get; set; }
        public int ChildrenUnder10 { get; set; }
        public int ChildrenUnder18 { get; set; }
    }
}
