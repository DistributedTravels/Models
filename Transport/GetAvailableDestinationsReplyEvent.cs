namespace Models.Transport
{
    public class GetAvailableDestinationsReplyEvent : EventModel
    {
        public Guid RequestId { get; set; }
        public IEnumerable<string> Destinations { get; set; }

        public GetAvailableDestinationsReplyEvent(Guid rId, IEnumerable<string> dests) : base()
        {
            RequestId = rId;
            Destinations = dests;
        }
    }
}
