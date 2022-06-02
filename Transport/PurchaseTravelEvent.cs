namespace Models.Transport
{
    public class PurchaseTravelEvent : EventModel
    {
        // new data to be transfered/saved to DB
        // add new data fields + a contstructor for them

        // no need to add the [JsonProperty] here according to MS Documentation/Source Code
        public Guid ReserveId { get; set; }

        public PurchaseTravelEvent(Guid reserveId) : base() // be wary of the base() call
        {
            this.ReserveId = reserveId;
        }

        public PurchaseTravelEvent() : base() { }
    }
}
