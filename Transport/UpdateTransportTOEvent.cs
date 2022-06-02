using Models.Transport.Dto;

namespace Models.Transport
{
    public class UpdateTransportTOEvent : EventModel
    {
        public enum Actions
        {
            NEW,
            UPDATE,
            DELETE
        }

        public enum Tables
        {
            DESTINATION,
            TRAVEL
        }

        public Actions Action { get; set; }
        public Tables Table { get; set; }

        public DestinationChangeDto DestinationDetails { get; set; }
        public TravelChangeDto TravelDetails { get; set; }

        public UpdateTransportTOEvent() : base() { }
    }


}
