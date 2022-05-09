namespace Models.Hotels
{
    public class GetHotelsEvent : EventModel
    {
        public String Country { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int AppartmentsAmount { get; set; }
        public int CasualRoomAmount { get; set; }
        public Boolean Breakfast { get; set; }
        public Boolean Internet { get; set; }


        public GetHotelsEvent(
            string country,
            DateTime beginDate,
            DateTime endDate,
            int appartmentsAmount,
            int casualRoomAmount,
            Boolean breakfast,
            Boolean internet) : base()
        {
            Country = country;
            BeginDate = beginDate;
            EndDate = endDate;
            AppartmentsAmount = appartmentsAmount;
            CasualRoomAmount = casualRoomAmount;
            Breakfast = breakfast;
            Internet = internet;
        }
    }
}
