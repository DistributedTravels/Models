namespace Models.Transport.Dto
{
    public class DestinationChangeDto
    {
        public string Name { get; set; } = "";
        public string NewName { get; set; } = ""; // only used for updating name!
        public int Distance { get; set; } = -1;
    }
}
