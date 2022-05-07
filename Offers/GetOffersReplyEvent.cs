using Models.Offers.Dto;
namespace Models.Offers
{
    public class GetOffersReplyEvent : EventModel
    {
        public IEnumerable<TripDto> Trips { get; set; }
    }
}
