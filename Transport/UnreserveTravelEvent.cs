namespace Models.Transport
{
    public class UnreserveTravelEvent : EventModel
    {
        public int TravelId { get; set; }

        public UnreserveTravelEvent(int tId) : base()
        { 
            TravelId = tId; 
        }
    }
}
