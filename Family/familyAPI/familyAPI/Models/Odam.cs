namespace familyAPI.Data
{
    public class Odam
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime dateBirth { get; set; }
        public int? FatherFK { get; set; }

        public Odam? Father { get; set; }
        public ICollection<Odam>? childs { get; set; }        
    }
}
