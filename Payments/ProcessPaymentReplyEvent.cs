namespace Models.Payments
{
    public class ProcessPaymentReplyEvent : EventModel
    {
        public enum State 
        { 
            ACCEPTED,
            INVALID_CARD_CREDENTIALS,
            LIMITS_TOO_LOW
        }
        public State Response { get; set; }

        public ProcessPaymentReplyEvent(State response, Guid correlationId) : base()
        {
            Response = response;
            CorrelationId = correlationId;
        }
		public ProcessPaymentReplyEvent() {}
    }
}
