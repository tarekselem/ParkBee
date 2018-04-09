
using Microsoft.EntityFrameworkCore;
using ParkBee.Models.Entities;

namespace ParkBee.Data.EFMemory
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
        : base(options)
        { }


        public DbSet<Garage> Garages { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<Owner> Owners { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseInMemoryDatabase(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
            }
        }
    }
}
