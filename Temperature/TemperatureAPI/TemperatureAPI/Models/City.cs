namespace TemperatureAPI.Data
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public DateTime date { get; set; }
        public double morning { get; set; }
        public double day { get; set; }
        public double evening { get; set; }
    }
}
