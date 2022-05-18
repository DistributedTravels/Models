namespace Models.Hotels
{
    public class GetHotelsEventReply : EventModel
    {
        public IEnumerable<HotelItem>? HotelItems { get; set; }
        public GetHotelsEventReply(IEnumerable<HotelItem>? hotelItems, Guid correlationID) : base()
        {
            HotelItems = hotelItems;
            CorrelationId = correlationID;
        }

        public GetHotelsEventReply() : base()
        {
            //HotelItems = new List<HotelItem>();
        }
    }

    public class HotelItem
    {
        public int HotelItemId { get; set; }
        public string HotelName { get; set; }
        public string HotelCountry { get; set; }

        public HotelItem(int hotelItemId, string hotelName, string hotelCountry)
        {
            HotelItemId = hotelItemId;
            HotelName = hotelName;
            HotelCountry = hotelCountry;
        }
    }
}
