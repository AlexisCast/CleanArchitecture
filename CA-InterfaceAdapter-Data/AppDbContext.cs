using CA_EnterpriseLayer;
using Microsoft.EntityFrameworkCore;

namespace CA_InterfaceAdapter_Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<Beer> Beers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // method that already exist, optionas to override since we are using a plural for 'Beer'
        {
            modelBuilder.Entity<Beer>().ToTable("Beer");
        }

    }
}
