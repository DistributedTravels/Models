namespace Models.Reservations
{
    public class AskForReservationStatusEvent : EventModel
    {
        public Guid ReservationId;
    }
}
