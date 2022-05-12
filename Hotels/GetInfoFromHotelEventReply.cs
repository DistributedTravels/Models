namespace Models.Hotels
{
    public class GetInfoFromHotelEventReply : EventModel
    {
        public enum State
        {
            CAN_BE_RESERVED,
            CAN_NOT_BE_RESERVED
        };

        public State Answer { get; set; }
        public double Price { get; set; }

        public GetInfoFromHotelEventReply(State ans, double price, Guid cId) : base()
        {
            Answer = ans;
            Price = price;
            CorrelationId = cId;
        }
    }
}
