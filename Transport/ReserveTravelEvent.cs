namespace Models.Transport
{
    public class ReserveTravelEvent : EventModel
    {
        public int TravelId { get; set; }
        public int Seats { get; set; }
        public Guid ReserveId { get; set; }
    }
}
