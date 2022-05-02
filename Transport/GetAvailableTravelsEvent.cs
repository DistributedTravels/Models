namespace Models.Transport
{
    public class GetAvailableTravelsEvent : EventModel
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public int FreeSeats { get; set; }

        public GetAvailableTravelsEvent(DateTime departure, int freeSeats, string source="any", string destination="any") : base()
        {
            this.Source = source;
            this.Destination = destination;
            this.DepartureTime = departure;
            this.FreeSeats = freeSeats;
        }
    }
}
