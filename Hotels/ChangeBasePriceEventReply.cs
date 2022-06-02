using Models.Hotels.Dto;

namespace Models.Hotels
{
    public class ChangeBasePriceEventReply : EventModel
    {
        public enum State
        {
            CHANGED,
            NOT_CHANGED
        };
        public State Answer;
        public IEnumerable<ResponseListDto>? ResponseListDto { get; set; }

        public ChangeBasePriceEventReply(State answer, IEnumerable<ResponseListDto>? responseListDto, Guid cId)
        {
            Answer = answer;
            ResponseListDto = responseListDto;
            CorrelationId = cId;
        }
    }
}
