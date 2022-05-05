using Database.Tables;
namespace Models.Offers
{
    public class GetOffersEventReply : EventModel
    {
        public IEnumerable<Trip> Trips { get; set; }
    }
}
