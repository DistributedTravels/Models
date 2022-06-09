namespace Models.Hotels
{
    public class DeleteRoomsInHotelEvent : EventModel
    {
        public int HotelId { get; set; }
        public int AppartmentsAmountToDelete { get; set; }
        public int CasualRoomAmountToDelete { get; set; }
    }
}
