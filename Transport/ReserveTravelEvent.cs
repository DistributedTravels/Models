namespace Models.Transport
{
    public class ReserveTravelEvent : EventModel
    {
        public int TravelId { get; set; }

        public ReserveTravelEvent(int tId) : base()
        {
            TravelId = tId;
        }
    }
}
