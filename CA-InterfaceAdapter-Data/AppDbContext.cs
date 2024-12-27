using CA_InterfaceAdapters_Models;
using Microsoft.EntityFrameworkCore;

namespace CA_InterfaceAdapter_Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        public DbSet<BeerModel> Beers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // method that already exist, optionas to override since we are using a plural for 'Beer'
        {
            modelBuilder.Entity<BeerModel>().ToTable("Beer");
        }

    }
}
