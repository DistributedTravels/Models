namespace Models.Hotels
{
    public class ChangeWifiAvailabilityEvent : EventModel
    {
        public string HotelName { get; set; }
        public bool Wifi { get; set; }
    }
}
