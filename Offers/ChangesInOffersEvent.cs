namespace Models.Offers
{
    public class ChangesInOffersEvent : EventModel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public int BigRoomsAvailable { get; set; }
        public int SmallRoomsAvaialable { get; set; }
        public bool WifiAvailable { get; set; }
        public bool BreakfastAvailable { get; set; }
        public double HotelPricePerPerson { get; set; }
        public int TransportId { get; set; }
        public double TransportPricePerSeat { get; set; }
        public bool PlaneAvailable { get; set; }
        public double BreakfastPrice { get; set; }
    }
}
