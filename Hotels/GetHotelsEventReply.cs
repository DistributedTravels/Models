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
        public double HotelBreakfastPrice { get; set; }
        public bool HotelHasWifi { get; set; }
        public double HotelPriceForNightForPerson { get; set; }
        public int ApartmentsAmount { get; set; }
        public int CasualRoomsAmount { get; set; }

        public HotelItem(int hotelItemId, string hotelName, string hotelCountry,
            double hotelBreakfastPrice, bool hotelHasWifi, double hotelPriceForNightForPerson,
            int apartmentsAmount, int casualRoomsAmount)
        {
            HotelItemId = hotelItemId;
            HotelName = hotelName;
            HotelCountry = hotelCountry;
            HotelBreakfastPrice = hotelBreakfastPrice;
            HotelHasWifi = hotelHasWifi;
            HotelPriceForNightForPerson = hotelPriceForNightForPerson;
            ApartmentsAmount = apartmentsAmount;
            CasualRoomsAmount = casualRoomsAmount;
        }
    }
}
