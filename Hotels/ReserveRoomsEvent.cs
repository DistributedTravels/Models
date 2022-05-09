namespace Models.Hotels
{
    public class ReserveRoomsEvent : EventModel
    {
        public String HotelName { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public int AppartmentsAmount { get; set; }
        public int CasualRoomAmount { get; set; }

        public ReserveRoomsEvent(
            string hotelName, DateTime beginDate, DateTime endDate,
            int appartmentsAmount, int casualRoomAmount,
            Boolean breakfast, Boolean internet
        ) : base()
        {
            HotelName = hotelName;
            BeginDate = beginDate;
            EndDate = endDate;
            AppartmentsAmount = appartmentsAmount;
            CasualRoomAmount = casualRoomAmount;
        }
    }
}
