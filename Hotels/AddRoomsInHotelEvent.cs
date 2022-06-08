namespace Models.Hotels
{
    public class AddRoomsInHotelEvent : EventModel
    {
        public int HotelId { get; set; }
        public int AppartmentsAmountToAdd { get; set; }
        public int CasualRoomAmountToAdd { get; set; }
    }
}
