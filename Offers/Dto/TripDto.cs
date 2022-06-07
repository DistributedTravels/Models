namespace Models.Offers.Dto
{
    public class TripDto
    {
        public int Id { get; set; }
        public int TransportId { get; set; }
        public string HotelName { get; set; }
        public int HotelId { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DepartureTime { get; set; }
        public int Adults { get; set; }
        public int ChildrenUnder3 { get; set; }
        public int ChildrenUnder10 { get; set; }
        public int ChildrenUnder18 { get; set; }
        public Guid TripId { get; set; }
        public double TransportPricePerSeat { get; set; }
        public double HotelPrice { get; set; }
        public double TotalPrice { get; set; }
        public bool WifiAvailable { get; set; }
        public bool BreakfastAvailable { get; set; }
        public int BigRoomsAvailable { get; set; }
        public int SmallRoomsAvailable { get; set; }
        public bool OfferAvailable { get; set; }
        public bool PlaneAvailable { get; set; }

        public TripDto()
        {
            TripId = Guid.NewGuid();
        }
    }
}
