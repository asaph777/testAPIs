<<<<<<< HEAD
﻿namespace TemperatureAPI.Data
{
    public class CityDb : DbContext
    {
        public CityDb(DbContextOptions<CityDb> options) : base(options) { }
        public DbSet<City> City => Set<City>();
    }
}
=======
﻿namespace TemperatureAPI.Data
{
    public class CityDb : DbContext
    {
        public CityDb(DbContextOptions<CityDb> options) : base(options) { }
        public DbSet<City> City => Set<City>();
    }
}
>>>>>>> 2913a87e4978204e8b72e499b616b9331073ee7b
