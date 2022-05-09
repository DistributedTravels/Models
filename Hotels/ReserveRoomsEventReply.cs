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

        public ReserveRoomsEventReply(State ans, Guid cId) : base()
        {
            Answer = ans;
            CorrelationId = cId;
        }
    }
}
