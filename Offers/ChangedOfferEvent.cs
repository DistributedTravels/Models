using Models.Offers.Dto;

namespace Models.Offers
{
    public class ChangedOfferEvent : EventModel
    {
        public TripDto OldOffer { get; set; }
        public TripDto NewOffer { get; set; }
    }
}
