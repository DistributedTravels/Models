namespace Models.Transport.Dto
{
    public class TravelChangeDto : ChangeDto
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public int AvailableSeats { get; set; }
        public double Price { get; set; }
    }
}
