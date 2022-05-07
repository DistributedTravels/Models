using Models.Offers.Dto;
namespace Models.Offers
{
    public class GetOffersEventReply : EventModel
    {
        public IEnumerable<TripDto> Trips { get; set; }
    }
}
