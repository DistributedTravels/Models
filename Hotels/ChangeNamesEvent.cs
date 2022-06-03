namespace Models.Hotels
{
    public class ChangeNamesEvent : EventModel
    {
        // accepted values:
        //      name
        //      country
        //      both
        public string ChangedParameter { get; set; }
        public string OldName { get; set; }
        public string NewName { get; set; }
        public string NewCountry { get; set; }
    }
}
