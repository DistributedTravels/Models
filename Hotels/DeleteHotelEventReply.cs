using Models.Hotels.Dto;

namespace Models.Hotels
{
    public class DeleteHotelEventReply : EventModel
    {
        public enum State
        {
            DELETED,
            NOT_DELETED
        };
        public State Answer;
        public IEnumerable<ResponseListDto>? ResponseListDto { get; set; }

        public DeleteHotelEventReply(State answer, IEnumerable<ResponseListDto>? responseListDto, Guid cId)
        {
            Answer = answer;
            ResponseListDto = responseListDto;
            CorrelationId = cId;
        }
    }
}
