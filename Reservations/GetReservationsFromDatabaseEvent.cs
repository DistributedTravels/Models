using Models.Reservations.Dto;

namespace Models.Reservations
{
    public class GetReservationsFromDatabaseEvent : EventModel
    {
        public Guid UserId { get; set; }
    }
}
