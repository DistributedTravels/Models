namespace Models.Hotels
{
    public class ChangeNamesEventReply : EventModel
    {
        public enum State
        {
            CHANGED,
            NOT_CHANGED
        };

        public State Answer { get; set; }
        public int HotelId { get; set; }
        public string HotelOldName { get; set; }
        public string HotelOldCountry { get; set; }
        public string HotelNewName { get; set; }
        public string HotelNewCountry { get; set; }
        public double HotelBreakfastPrice { get; set; }
        public bool HotelHasWifi { get; set; }
        public double HotelPriceForNightForPerson { get; set; }

        public ChangeNamesEventReply(State ans, int hId, string oN, string oC, string nN, string nC, double bP, bool wifi, double prc, Guid cId) : base()
        {
            Answer = ans;
            HotelId = hId;
            HotelOldName = oN;
            HotelOldCountry = oC;
            HotelNewName = nN;
            HotelNewCountry = nC;
            HotelBreakfastPrice = bP;
            HotelHasWifi = wifi;
            HotelPriceForNightForPerson = prc;
            CorrelationId = cId;
        }
        public ChangeNamesEventReply(State ans, Guid cId) : base()
        {
            Answer = ans;
            HotelId = 0;
            HotelOldName = "";
            HotelOldCountry = "";
            HotelNewName = "";
            HotelNewCountry = "";
            HotelBreakfastPrice = -1.0;
            HotelHasWifi = false;
            HotelPriceForNightForPerson = 0.0;
            CorrelationId = cId;
        }
    }
}
