using Models.Transport;

namespace Models.Offers.Dto
{
    // TODO check if not redundant
    public class TravelDto
    {
        public int TravelId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public int AvailableSeats { get; set; }
        public double PricePerSeat { get; set; }

        public TravelDto(int id, string source, string destination, DateTime departureTime, int seats, double price)
        {
            TravelId = id;
            Source = source;
            Destination = destination;
            DepartureTime = departureTime;
            AvailableSeats = seats;
            PricePerSeat = price;
        }
        public TravelDto(TravelItem travel)
        {
            TravelId = travel.TravelId;
            Source = travel.Source;
            Destination = travel.Destination;
            DepartureTime = travel.DepartureTime;
            AvailableSeats = travel.AvailableSeats;
            PricePerSeat = travel.Price;
        }
    }
}
