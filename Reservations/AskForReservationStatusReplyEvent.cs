namespace Models.Reservations
{
    public class AskForReservationStatusReplyEvent : EventModel
    {
        public Guid ReservationId { get; set; }
        public enum Status
        {
            WAITING_FOR_RESERVATION,
            WAITING_FOR_PAYMENT,
            SUCCESFUL,
            FAILED
        }
        public Status ReservationStatus { get; set; }
        public double Price;
    }
}
