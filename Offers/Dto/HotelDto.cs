namespace Models.Offers.Dto
{
    // TODO check if not redundant
    public class HotelDto
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public HotelDto(int id, string name)
        {
            HotelId = id;
            Name = name;
        }
    }
}
