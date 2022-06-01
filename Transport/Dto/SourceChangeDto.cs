namespace Models.Transport.Dto
{
    public class SourceChangeDto
    {
        public string Name { get; set; } = "";
        public string NewName { get; set; } = ""; // only used for updating name!
    }
}
