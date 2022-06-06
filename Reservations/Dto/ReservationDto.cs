namespace Models.Reservations.Dto
{
    public class ReservationDto
    {
        public Guid UserId { get; set; }
        public int TransportId { get; set; }
        public string? HotelName { get; set; }
        public int HotelId { get; set; }
        public string? Destination { get; set; }
        public string? Departure { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Status { get; set; }
        public int Adults { get; set; }
        public int ChildrenUnder3 { get; set; }
        public int ChildrenUnder10 { get; set; }
        public int ChildrenUnder18 { get; set; }
        public int SmallRooms { get; set; }
        public int BigRooms { get; set; }
        public bool HasInternet { get; set; }
        public bool HasBreakfast { get; set; }
        public bool HasOwnTransport { get; set; }
        public double TransportPricePerSeat { get; set; }
        public double HotelPrice { get; set; }
        public double TotalPrice { get; set; }
        public Guid ReservationId { get; set; }
        public bool HasDiscount { get; set; }
    }
}
