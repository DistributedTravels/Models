namespace Models.Transport
{
    public class ReserveTravelReplyEvent : EventModel
    {
        public enum State { 
            RESERVED,
            NOT_RESERVED
        };

        public State Answer { get; set; }
        public double Price { get; set; }

        public ReserveTravelReplyEvent(State answer, Guid corellationId, double price) : base()
        {
            Answer = answer;
            CorrelationId = corellationId;
            Price = price;
        }
    }
}
