namespace Models.Hotels.Dto
{
    public class ResponseListDto
    {
        public Guid ReservationNumber { get; set; }
        public Guid UserId { get; set; }
        public double CalculatedCost { get; set; }
        public int AppartmentsAmount { get; set; }
        public int CasualRoomsAmount { get; set; }
    }

    public class ResponseListDtoComparer : IEqualityComparer<ResponseListDto>
    {
        public bool Equals(ResponseListDto? a, ResponseListDto? b)
        {
            if (a == null || b == null)
                return false;
            if (a.ReservationNumber.CompareTo(b.ReservationNumber) == 0)
                return true;
            else
                return false;
        }
        public int GetHashCode(ResponseListDto obj)
        {
            return obj.ReservationNumber.GetHashCode();
        }
    }
}
