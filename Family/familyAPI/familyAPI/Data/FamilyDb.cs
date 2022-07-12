using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace familyAPI.Data
{
    public class FamilyDb : DbContext
    {
        public FamilyDb(DbContextOptions<FamilyDb> options) : base(options) { }
        public DbSet<Odam> Odam => Set<Odam>();        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<Odam>()
                .HasKey(o=>o.Id);
            
            modelBuilder.Entity<Odam>()
                .Property(o => o.FatherFK).HasColumnName("father");

            modelBuilder.Entity<Odam>()
                .HasOne<Odam>(o => o.Father)
                .WithMany(o => o.Childs)
                .HasForeignKey(o=>o.FatherFK);
        }             
    }    
}
