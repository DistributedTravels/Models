using Models.Hotels.Dto;

namespace Models.Hotels
{
    public class ChangeBreakfastPriceEventReply : EventModel
    {
        public enum State
        {
            PRICE_CHANGED,
            PRICE_NOT_CHANGED,
            BREAKFAST_NO_MORE_AVAILABLE,
            BREAKFAST_BECOME_AVAILABLE
        };
        public State Answer;
        public IEnumerable<ResponseListDto>? ResponseListDto { get; set; }

        public ChangeBreakfastPriceEventReply(State answer, IEnumerable<ResponseListDto>? responseListDto, Guid cId)
        {
            Answer = answer;
            ResponseListDto = responseListDto;
            CorrelationId = cId;
        }
    }
}
