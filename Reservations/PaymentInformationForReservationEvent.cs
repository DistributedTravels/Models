using Models;
using Models.Payments;

namespace Models.Reservations
{
    public class PaymentInformationForReservationEvent : EventModel
    {
        public CardCredentials Card { get; set; }
        public double Price { get; set; }

        public PaymentInformationForReservationEvent(CardCredentials card, double price) : base()
        {
            Card = card;
            Price = price;
        }
    }
}
