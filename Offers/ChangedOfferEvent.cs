using Models.Offers.Dto;

namespace Models.Offers
{
    public class ChangedOfferEvent : EventModel
    {
        public TripDto oldOffer { get; set; }
        public TripDto newOffer { get; set; }
    }
}
