namespace Models.Hotels
{
    public class ChangeWifiAvailabilityEvent : EventModel
    {
        public int HotelId { get; set; }
        public bool Wifi { get; set; }
    }
}
