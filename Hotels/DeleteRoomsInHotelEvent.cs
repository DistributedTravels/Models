namespace Models.Hotels
{
    public class DeleteRoomsInHotelEvent : EventModel
    {
        public string HotelName { get; set; }
        public int AppartmentsAmountToDelete { get; set; }
        public int CasualRoomAmountToDelete { get; set; }
    }
}
