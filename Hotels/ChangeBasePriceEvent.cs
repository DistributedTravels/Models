namespace Models.Hotels
{
    public class ChangeBasePriceEvent : EventModel
    {
        public string HotelName { get; set; }
        public double NewPrice { get; set; }
    }
}
