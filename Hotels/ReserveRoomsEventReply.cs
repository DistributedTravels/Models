namespace Models.Hotels
{
    public class ReserveRoomsEventReply : EventModel
    {
        public enum State
        {
            RESERVED,
            NOT_RESERVED
        };

        public State Answer { get; set; }
        public double Price { get; set; }

        public ReserveRoomsEventReply(State ans, double price, Guid cId) : base()
        {
            Answer = ans;
            Price = price;
            CorrelationId = cId;
        }

        public ReserveRoomsEventReply() : base()
        {
            Answer = State.NOT_RESERVED;
            Price = 0.0;
        }
    }
}
