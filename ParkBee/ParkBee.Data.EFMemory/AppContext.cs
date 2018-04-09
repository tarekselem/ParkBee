
using Microsoft.EntityFrameworkCore;

namespace ParkBee.Data.EFMemory
{
    public class AppContext : DbContext
    {
        public AppContext()
        {
        }

        public AppContext(DbContextOptions<AppContext> options)
        : base(options)
        { }


        public DbSet<Entities.Garage> Garages { get; set; }
        public DbSet<Entities.Door> Doors { get; set; }
        public DbSet<Entities.Owner> Owners { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
            }
        }
    }
}
