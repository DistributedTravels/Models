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
            SOURCE,
            TRAVEL
        }

        public Actions Action { get; set; }
        public Tables Table { get; set; }

        public DestinationChangeDto DestinationDetails { get; set; }
        public SourceChangeDto SourceDetails { get; set; }
        public TravelChangeDto TravelDetails { get; set; }

        public UpdateTransportTOEvent() : base() { }
    }


}
