namespace Models.Transport
{
    public class ReserveTravelEvent : EventModel
    {
        public int TravelId { get; set; }
        public int Seats { get; set; }

        public Guid UserId { get; set; }

        public ReserveTravelEvent(int tId, int seats, Guid uId) : base()
        {
            TravelId = tId;
            Seats = seats;
            UserId = uId;
        }
    }
}
