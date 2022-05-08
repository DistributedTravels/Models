namespace Models.Transport
{
    public class ReserveTravelReplyEvent : EventModel
    {
        public enum State { 
            RESERVED,
            NOT_RESERVED
        };

        public State Answer { get; set; }

        public ReserveTravelReplyEvent(State ans, Guid cId) : base()
        {
            Answer = ans;
            CorrelationId = cId;
        }
    }
}
