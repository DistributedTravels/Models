namespace Models.Hotels
{
    public class ChangeNamesEvent : EventModel
    {
        public int HotelId { get; set; }
        public string NewName { get; set; }
    }
}
