namespace Models.Transport
{
    public class GetAvailableSourcesReplyEvent : EventModel
    {
        public Guid RequestId { get; set; }
        public IEnumerable<string> Sources { get; set; }

        public GetAvailableSourcesReplyEvent(Guid requestId, Guid correlationId, IEnumerable<string> sources) : base()
        {
            RequestId = requestId;
            CorrelationId = correlationId;
            Sources = sources;
        }
    }
}
