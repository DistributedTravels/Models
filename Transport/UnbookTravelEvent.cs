namespace Models.Transport
{
    public class UnbookTravelEvent : EventModel
    {
        public int FlightId { get; set; }
        public int Seats { get; set; }

        public Guid UserId { get; set; }

        public UnbookTravelEvent(int flightId, int seats, Guid uId) : base()
        {
            this.FlightId = flightId;
            this.Seats = seats;
            this.UserId = uId;
        }
    }
}
