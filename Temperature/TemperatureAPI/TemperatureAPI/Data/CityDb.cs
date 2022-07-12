namespace TemperatureAPI.Data
{
    public class CityDb : DbContext
    {
        public CityDb(DbContextOptions<CityDb> options) : base(options) { }
        public DbSet<City> City => Set<City>();
    }
}
