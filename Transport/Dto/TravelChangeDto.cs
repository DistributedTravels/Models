namespace Models.Transport.Dto
{
    public class TravelChangeDto
    {
        public int Id { get; set; } = -1;
        public int Source { get; set; } = -1;
        public int Destination { get; set; } = -1;
        public bool Direction { get; set; } = false;
        public DateTime DepartureTime { get; set; } = DateTime.UnixEpoch;
        public int AvailableSeats { get; set; } = -1;
        public double Price { get; set; } = -1;
    }
}
