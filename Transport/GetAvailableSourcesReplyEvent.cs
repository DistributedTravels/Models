namespace Models.Transport
{
    public class GetAvailableSourcesReplyEvent
    {
        public Guid RequestId { get; set; }
        public IEnumerable<string> Sources { get; set; }

        public GetAvailableSourcesReplyEvent(Guid rId, IEnumerable<string> srcs) : base()
        {
            RequestId = rId;
            Sources = srcs;
        }
    }
}
