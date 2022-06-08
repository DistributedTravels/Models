namespace Models.Hotels
{
    public class ChangeBasePriceEvent : EventModel
    {
        public int HotelId { get; set; }
        public double NewPrice { get; set; }
    }
}
