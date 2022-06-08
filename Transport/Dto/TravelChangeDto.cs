namespace Models.Transport.Dto
{
    public class TravelChangeDto
    {
        public int Id { get; set; } = -1;
        public string Source { get; set; } = "";
        public string Destination { get; set; } = "";
        public DateTime DepartureTime { get; set; } = DateTime.UnixEpoch;
        public int AvailableSeats { get; set; } = -1;
        public double Price { get; set; } = -1;
    }
}
