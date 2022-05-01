namespace Models.Transport
{
    public class GetAvailableTravelsEvent : EventModel
    {
        public static readonly string Flight = "flight";
        public static readonly string Coach = "coach";

        public string Source { get; set; }
        public string Destination { get; set; }
        public string Type { get; set; } // possibly obsolete
        public DateTime DepartureTime { get; set; }
        public int FreeSeats { get; set; }

        public GetAvailableTravelsEvent(DateTime departure, int freeSeats, string source="any", string destination="any", string type="any") : base()
        {
            this.Source = source;
            this.Destination = destination;
            this.Type = type;
            this.DepartureTime = departure;
            this.FreeSeats = freeSeats;
        }
    }
}
