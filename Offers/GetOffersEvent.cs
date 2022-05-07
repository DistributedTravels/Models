namespace Models.Offers;

public class GetOffersEvent : EventModel
{
    public string? Destination { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public int NumberOfPeople { get; set; }

    public GetOffersEvent(string destination, DateTime beginDate, DateTime endDate, int numberOfPeople) : base()
    {
        Destination = destination;
        BeginDate = beginDate;
        EndDate = endDate;
        NumberOfPeople = numberOfPeople;
    }
}