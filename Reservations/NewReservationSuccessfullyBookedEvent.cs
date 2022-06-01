namespace Models.Reservations
{
    public class NewReservationSuccessfullyBookedEvent : EventModel
    {
        public string Destination { get; set; }
        public string HotelName { get; set; }
        public string User { get; set; }
        public int SmallRooms { get; set; }
        public int BigRooms { get; set; }
        public bool HasOwnTransport { get; set; }
    }
}
