namespace familyAPI.Data
{
    public class FamilyDB : DbContext
    {
        public FamilyDB(DbContextOptions<FamilyDB> options): base(options){}
        public DbSet<Odam> Odam => Set<Odam>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Odam>()
                .HasKey(o => o.Id);

            modelBuilder.Entity<Odam>()
                .Property(o => o.FatherFK).HasColumnName("father");

            modelBuilder.Entity<Odam>()
                .HasOne<Odam>(o => o.Father)
                .WithMany(o => o.childs)
                .HasForeignKey(o => o.FatherFK);
        }
    }
}
