namespace Models.Offers.Dto
{
    public class TripDto
    {
        public int Id { get; set; }
        public int TransportId { get; set; }
        public string? HotelName { get; set; }
        public int HotelId { get; set; }
        public string? Destination { get; set; }
        public int NumberOfPeople { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
