namespace Models.Transport
{
    public class GetAvailableDestinationsReplyEvent : EventModel
    {
        public Guid RequestId { get; set; }
        public IEnumerable<string> Destinations { get; set; }

        public GetAvailableDestinationsReplyEvent(Guid rId, Guid cId, IEnumerable<string> dests) : base()
        {
            RequestId = rId;
            CorrelationId = cId;
            Destinations = dests;
        }
    }
}
