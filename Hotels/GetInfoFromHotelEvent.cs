namespace Models.Hotels
{
    public class GetInfoFromHotelEvent : EventModel
    {
        public int HotelId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int AppartmentsAmount { get; set; }
        public int CasualRoomAmount { get; set; }
        public Boolean Breakfast { get; set; }
        public Boolean Wifi { get; set; }

        public GetInfoFromHotelEvent(
            int hotelId, DateTime beginDate, DateTime endDate,
            int appartmentsAmount, int casualRoomAmount,
            Boolean breakfast, Boolean wifi) : base()
        {
            HotelId = hotelId;
            BeginDate = beginDate;
            EndDate = endDate;
            AppartmentsAmount = appartmentsAmount;
            CasualRoomAmount = casualRoomAmount;
            Breakfast = breakfast;
            Wifi = wifi;
        }

        public GetInfoFromHotelEvent() : base()
        {
            HotelId = 1;
            BeginDate = new DateTime(2022, 1, 1).ToUniversalTime();
            EndDate = new DateTime(2022, 1, 1).ToUniversalTime();
            AppartmentsAmount = 0;
            CasualRoomAmount = 0;
            Breakfast = false;
            Wifi = false;
        }
    }
}
