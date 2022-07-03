namespace familyAPI.Data
{
    public class Odam
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateBirth { get; set; }
        public int? Father { get; set; }
    }
}
