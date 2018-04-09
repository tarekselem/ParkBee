

namespace ParkBee.Data.Common
{
    public interface IUnitOfWork
    {
        IRepository<T> RepositoryFor<T>() where T : class;
        int SaveChanges();
    }
}
