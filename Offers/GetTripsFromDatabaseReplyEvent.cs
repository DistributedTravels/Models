using Models.Offers.Dto;

namespace Models.Offers
{
    public class GetTripsFromDatabaseReplyEvent : EventModel
    {
        public IEnumerable<TripDto> Trips { get; set; }
    }
}
