namespace familyAPI.Data
{
    public class Odam
    {        
        public int? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateBirth { get; set; }                        
        public int? FatherFK { get; set; }         

        public virtual Odam? Father { get; set; }
        public virtual ICollection<Odam>? Childs { get; set; }        
    }
}
