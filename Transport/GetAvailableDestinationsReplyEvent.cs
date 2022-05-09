namespace Models.Transport
{
    public class GetAvailableDestinationsReplyEvent : EventModel
    {
        public Guid RequestId { get; set; }
        public IEnumerable<string> Destinations { get; set; }

        public GetAvailableDestinationsReplyEvent(Guid requestId, Guid correlationId, IEnumerable<string> destinations) : base()
        {
            RequestId = requestId;
            CorrelationId = correlationId;
            Destinations = destinations;
        }
    }
}
