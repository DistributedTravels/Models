namespace Models.Hotels
{
    public class GetHotelsEventReply : EventModel
    {
        public IEnumerable<HotelItem>? HotelItems { get; }
        public GetHotelsEventReply(IEnumerable<HotelItem>? hotelItems) : base()
        {
            HotelItems = hotelItems;
        }
    }

    public class HotelItem
    {
        public int HotelItemId { get; set; }
        public string HotelName { get; set; }

        public HotelItem(int hotelItemId, string hotelName)
        {
            HotelItemId = hotelItemId;
            HotelName = hotelName;
        }
    }
}
