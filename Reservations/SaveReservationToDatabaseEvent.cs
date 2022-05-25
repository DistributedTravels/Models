using Models.Reservations.Dto;

namespace Models.Reservations
{
    public class SaveReservationToDatabaseEvent : EventModel
    {
        public ReservationDto Reservation { get; set; }
    }
}
