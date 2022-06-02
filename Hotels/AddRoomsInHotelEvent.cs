namespace Models.Hotels
{
    public class AddRoomsInHotelEvent : EventModel
    {
        public string HotelName { get; set; }
        public int AppartmentsAmountToAdd { get; set; }
        public int CasualRoomAmountToAdd { get; set; }
    }
}
