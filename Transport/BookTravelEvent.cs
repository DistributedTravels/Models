namespace Models.Transport
{
    public class BookTravelEvent : EventModel
    {
        // new data to be transfered/saved to DB
        // add new data fields + a contstructor for them

        // no need to add the [JsonProperty] here according to MS Documentation/Source Code
        public int FlightId { get; set; }
        public int Seats { get; set; }
        public Guid UserId { get; set; }

        public BookTravelEvent(int flightId, int seats, Guid uId) : base() // be wary of the base() call
        {
            this.FlightId = flightId;
            this.Seats = seats;
            this.UserId = uId;
        }
    }
}
