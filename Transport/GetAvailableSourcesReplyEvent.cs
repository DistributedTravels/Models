namespace Models.Transport
{
    public class GetAvailableSourcesReplyEvent : EventModel
    {
        public Guid RequestId { get; set; }
        public IEnumerable<string> Sources { get; set; }

        public GetAvailableSourcesReplyEvent(Guid rId, Guid cId, IEnumerable<string> srcs) : base()
        {
            RequestId = rId;
            CorrelationId = cId;
            Sources = srcs;
        }
    }
}
