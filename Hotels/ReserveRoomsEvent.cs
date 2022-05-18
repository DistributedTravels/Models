namespace Models.Hotels
{
    public class ReserveRoomsEvent : EventModel
    {
        public int HotelId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        public int AppartmentsAmount { get; set; }
        public int CasualRoomAmount { get; set; }
        public Guid UserId { get; set; }
        public Guid ReservationNumber { get; set; }
        public Boolean Breakfast { get; set; }
        public Boolean Wifi { get; set; }
    }
}
