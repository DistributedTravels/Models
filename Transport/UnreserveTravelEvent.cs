namespace Models.Transport
{
    public class UnreserveTravelEvent : EventModel
    {
        public Guid ReserveId { get; set; }
        public UnreserveTravelEvent(Guid reserveId) : base()
        { 
            ReserveId = reserveId;
        }
    }
}
