using Offers.Handlers;

namespace Models.Offers;

public class GetOffersEvent : EventModel
{
    public string? Destination { get; set; }
    public DateOnly BeginDate { get; set; }
    public DateOnly EndDate { get; set; }
    public int NumberOfPeople { get; set; }

    public GetOffersEvent(string destination, DateOnly beginDate, DateOnly endDate, int numberOfPeople) : base()
    {
        Destination = destination;
        BeginDate = beginDate;
        EndDate = endDate;
        NumberOfPeople = numberOfPeople;
    }
}