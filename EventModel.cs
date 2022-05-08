using Newtonsoft.Json;
namespace Models
{
    // Class to inherit after for differnt types of events
    public class EventModel
    {
        [JsonProperty]
        public Guid Id { get; set; }
        
        [JsonProperty]
        public Guid CorrelationId { get; set; }

        [JsonProperty]
        public DateTime CreationDate { get; private set; }

        [JsonConstructor]
        public EventModel(Guid id, DateTime date, Guid cId)
        {
            Id = id;
            CreationDate = date;
            CorrelationId = cId;
        }

        public EventModel()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
            CorrelationId = Guid.NewGuid();
        }
    }
}

// https://github.com/dotnet-architecture/eShopOnContainers/blob/main/src/BuildingBlocks/EventBus/EventBus/Events/IntegrationEvent.cs
