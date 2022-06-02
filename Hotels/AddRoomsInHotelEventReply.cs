namespace Models.Hotels
{
    public class AddRoomsInHotelEventReply : EventModel
    {
        public enum State
        {
            ADDED,
            NOT_ADDED
        };
        public State Answer;

        public AddRoomsInHotelEventReply(State answer, Guid cId)
        {
            Answer = answer;
            CorrelationId = cId;
        }
    }
}
