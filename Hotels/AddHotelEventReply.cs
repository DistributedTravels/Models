namespace Models.Hotels
{
    public class AddHotelEventReply : EventModel
    {
        public enum State
        {
            ADDED,
            NOT_ADDED
        };
        public State Answer;

        public AddHotelEventReply(State answer, Guid cId)
        {
            Answer = answer;
            CorrelationId = cId;
        }
    }
}
