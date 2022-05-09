namespace Models.Transport
{
    public class ReserveTravelReplyEvent : EventModel
    {
        public enum State { 
            RESERVED,
            NOT_RESERVED
        };

        public State Answer { get; set; }

        public ReserveTravelReplyEvent(State answer, Guid corellationId) : base()
        {
            Answer = answer;
            CorrelationId = corellationId;
        }
    }
}
