namespace Models.WebAPI
{
    public class CheckOfferAvailabilityResponse : EventModel
    {
        public bool Answer { get; set; }
        public double Price { get; set; }
    }
}