namespace Models.Transport
{
    public class UnpurchaseTravelEvent : EventModel
    {
        public Guid ReserveId { get; set; }

        public UnpurchaseTravelEvent(Guid reserveId) : base()
        {
            this.ReserveId = reserveId;
        }

        public UnpurchaseTravelEvent() : base() { }
    }
}
