﻿using Newtonsoft.Json;
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

        public Guid ProcessingId { get; set; }

        [JsonConstructor]
        public EventModel(Guid id, DateTime date)
        {
            Id = id;
            CreationDate = date;
        }

        public EventModel()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }
    }
}

// https://github.com/dotnet-architecture/eShopOnContainers/blob/main/src/BuildingBlocks/EventBus/EventBus/Events/IntegrationEvent.cs
