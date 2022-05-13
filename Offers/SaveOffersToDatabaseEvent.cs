using Models.Offers.Dto;
namespace Models.Offers
{
    public class SaveOffersToDatabaseEvent : EventModel
    {
        public IEnumerable<TripDto> Trips { get; set; }
    }
}
