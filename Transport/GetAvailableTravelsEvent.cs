namespace Models.Transport
{
    public class GetAvailableTravelsEvent : EventModel
    {
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public int FreeSeats { get; set; }
        public int? TravelId { get; set; }

        public GetAvailableTravelsEvent(DateTime departureTime, int freeSeats, string source="any", string destination="any", int? travelId = null) : base()
        {
            this.Source = source;
            this.Destination = destination;
            this.DepartureTime = departureTime;
            this.FreeSeats = freeSeats;
            this.TravelId = travelId;
        }
    }
}
