namespace Models.Offers;

public class GetOffersEvent : EventModel
{
    public string Destination { get; set; }
    public string Departure { get; set; }
    public DateTime BeginDate { get; set; }
    public DateTime EndDate { get; set; }
    public int NumberOfPeople { get; set; }
    public int Adults { get; set; }
    public int ChildrenUnder3 { get; set; }
    public int ChildrenUnder10 { get; set; }
    public int ChildrenUnder18 { get; set; }

    public GetOffersEvent(string destination, string departure, DateTime beginDate, DateTime endDate, int numberOfPeople, int adults, int childrenUnder3, int childrenUnder10, int childrenUnder18) : base()
    {
        Destination = destination;
        Departure = departure;
        BeginDate = beginDate;
        EndDate = endDate;
        NumberOfPeople = numberOfPeople;
        Adults = adults;
        ChildrenUnder3 = childrenUnder3;
        ChildrenUnder10 = childrenUnder10;
        ChildrenUnder18 = childrenUnder18;
    }
}