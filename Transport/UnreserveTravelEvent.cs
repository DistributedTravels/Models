namespace Models.Transport
{
    public class UnreserveTravelEvent : EventModel
    {
        public int TravelId { get; set; }
        public Guid UserId { get; set; }
        public int Seats { get; set; }
        public UnreserveTravelEvent(int tId, Guid uId, int seats) : base()
        { 
            TravelId = tId; 
            UserId = uId;
            Seats = seats;
        }
    }
}
