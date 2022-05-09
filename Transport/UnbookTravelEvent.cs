namespace Models.Transport
{
    public class UnbookTravelEvent : EventModel
    {
        public int FlightId { get; set; }
        public int Seats { get; set; }

        public Guid BookingId { get; set; }

        public UnbookTravelEvent(int flightId, int seats, Guid bookingId) : base()
        {
            this.FlightId = flightId;
            this.Seats = seats;
            this.BookingId = bookingId;
        }
    }
}
