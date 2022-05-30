namespace Models.Reservations
{
    public class NewReservationSuccessfullyBookedEvent : EventModel
    {
        public string Destination { get; set; }
        public string HotelName { get; set; }
        public string User { get; set; }
    }
}
