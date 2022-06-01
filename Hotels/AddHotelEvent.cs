namespace Models.Hotels
{
    public class AddHotelEvent : EventModel
    {
        public string Name { get; set; }
        public string Country { get; set; }
        //potetially could be more conveniences
        public double BreakfastPrice { get; set; }
        public bool HasWifi { get; set; }
        public double PriceForNightForPerson { get; set; }
        public int AppartmentsAmount { get; set; }
        public int CasualRoomAmount { get; set; }
    }
}
