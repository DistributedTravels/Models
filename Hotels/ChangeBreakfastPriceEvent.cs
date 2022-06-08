namespace Models.Hotels
{
    public class ChangeBreakfastPriceEvent : EventModel
    {
        public int HotelId { get; set; }
        public double NewPrice { get; set; }
    }
}
