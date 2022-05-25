using Models.Reservations.Dto;

namespace Models.Reservations
{
    public class GetReservationsFromDatabaseReplyEvent : EventModel
    {
        public IEnumerable<ReservationDto> Reservations { get; set; }
    }
}
