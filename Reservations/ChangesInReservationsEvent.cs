namespace Models.Reservations
{
    public class ChangesInReservationsEvent : EventModel
    {
        // reservation which might be affected by change - Guid.Empty if multiple/all
        public Guid ReservationId { get; set; }
        public HotelChange ChangesInHotel { get; set; }
        public TransportChange ChangesInTransport { get; set; }
        public bool ReservationAvailable { get; set; }
    }
    
    public class HotelChange
    {
        // changed hotel id - -1 if not applicable
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public double ChangeInHotelPrice { get; set; }
        public bool WifiAvailable { get; set; }
        public bool BreakfastAvailable { get; set; }
        public bool HotelAvailable { get; set; }
        public int SmallRoomNumberChange { get; set; }
        public int BigRoomNumberChange { get; set; }
    }
    public class TransportChange
    {
        // changed flight id - -1 if not applicable
        public int TransportId { get; set; }
        public double ChangeInTransportPrice { get; set; }
        public bool PlaneAvailable { get; set; }
        public int FreeSeatsChange { get; set; }
    }
}
