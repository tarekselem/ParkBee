using ParkBee.Data.Common;
using ParkBee.Data.EFMemory;
using ParkBee.Services.Implementations;
using ParkBee.Services.Interfaces;
using Unity;
using Unity.Lifetime;

namespace ParkBee.CrossCutting
{
    public static class UnityConfiguration
    {
        private static UnityContainer _container;
        public static UnityContainer Container => _container ?? (_container = new UnityContainer());

        public static void RegisterTypes()
        {
            Container.RegisterType<IUnitOfWork, UnitOfWork>(new PerThreadLifetimeManager());
            Container.RegisterType(typeof(IRepository<>), typeof(Repository<>));

            Container.RegisterType<IGaragesService, GaragesService>();
        }
    }
}
