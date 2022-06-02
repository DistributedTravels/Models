namespace Models.Hotels
{
    public class ChangeBreakfastPriceEvent : EventModel
    {
        public string HotelName { get; set; }
        public double NewPrice { get; set; }
    }
}
