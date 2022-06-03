using Models.Hotels.Dto;

namespace Models.Hotels
{
    public class ChangeWifiAvailabilityEventReply : EventModel
    {
        public enum State
        {
            WIFI_SET,
            WIFI_UNSET,
            WIFI_UNCHANGED
        };
        public State Answer;
        public IEnumerable<ResponseListDto>? ResponseListDto { get; set; }

        public ChangeWifiAvailabilityEventReply(State answer, IEnumerable<ResponseListDto>? responseListDto, Guid cId)
        {
            Answer = answer;
            ResponseListDto = responseListDto;
            CorrelationId = cId;
        }
    }
}
