namespace Models.Hotels
{
    public class UnreserveRoomsEventReply : EventModel
    {
        public enum State
        {
            RESERVED,
            NOT_RESERVED
        };

        public State Answer { get; set; }

        public UnreserveRoomsEventReply(State ans, Guid cId) : base()
        {
            Answer = ans;
            CorrelationId = cId;
        }
    }
}
