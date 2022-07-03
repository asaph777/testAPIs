namespace familyAPI.Data
{
    public class FamilyDb : DbContext
    {
        public FamilyDb(DbContextOptions<FamilyDb> options) : base(options) { }
        public DbSet<Odam> Odam => Set<Odam>();
    }
}
