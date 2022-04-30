namespace Models.Transport
{
    public class GetAvailableTravelsReplyEvent: EventModel
    {
        public Guid RequestId { get; set; }
        public IEnumerable<TravelItem>? TravelItems { get; }

        public GetAvailableTravelsReplyEvent(Guid requestId, IEnumerable<TravelItem>? travelItems) : base()
        {
            RequestId = requestId;
            TravelItems = travelItems;
        }
    }

    public class TravelItem
    {
        public int TravelId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Type { get; set; }
        public int AvailableSeats { get; set; }

        public TravelItem(int id, string source, string destination, DateTime departureTime, string type, int seats)
        {
            TravelId = id;
            Source = source;
            Destination = destination;
            DepartureTime = departureTime;
            Type = type;
            AvailableSeats = seats;
        }
    }
}
