namespace Models.Payments
{
    public class ProcessPaymentEvent : EventModel
    {
        public CardCredentials Card { get; set; }
        public double Price { get; set; }

        public ProcessPaymentEvent(CardCredentials card, double price) : base()
        {
            Card = card;
            Price = price;
        }
    }

    public class CardCredentials
    {
        public string Number { get; set; }
        public int CVV { get; set; }
        public string ExpDate { get; set; }
        public string FullName { get; set; }
    }
}
