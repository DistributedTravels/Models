namespace Models.Reservations
{
    public class ReserveOfferEvent : EventModel
    {
        public Guid ReservationId { get; set; }
        public Guid OfferId { get; set; }
        public Guid UserId { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DepartureTime { get; set; }
        public int NumberOfPeople { get; set; }
        public int TransportId { get; set; }
        public string? HotelName { get; set; }
        public int HotelId { get; set; }
        public int Adults { get; set; }
        public int ChildrenUnder3 { get; set; }
        public int ChildrenUnder10 { get; set; }
        public int ChildrenUnder18 { get; set; }
        public int SmallRooms { get; set; }
        public int BigRooms { get; set; }
        public bool HasInternet { get; set; }
        public bool HasBreakfast { get; set; }
        public bool HasOwnTransport { get; set; }
        public bool HasPromotionCode { get; set; }
    }
}
