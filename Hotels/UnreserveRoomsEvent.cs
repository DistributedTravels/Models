namespace Models.Hotels
{
    public class UnreserveRoomsEvent : EventModel
    {
        public Guid ReservationNumber { get; set; }

        public UnreserveRoomsEvent(Guid reservationNumber) : base()
        {
            ReservationNumber = reservationNumber;
        }
    }
}
