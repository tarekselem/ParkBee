using Microsoft.Extensions.DependencyInjection;
using ParkBee.Data.Common;
using ParkBee.Data.EFMemory;
using ParkBee.Services.Implementations;
using ParkBee.Services.Interfaces;

namespace ParkBee.CrossCutting
{
    public static class DIConfigurations
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));

            services.AddTransient<IGaragesService, GaragesService>();
        }
    }
}
