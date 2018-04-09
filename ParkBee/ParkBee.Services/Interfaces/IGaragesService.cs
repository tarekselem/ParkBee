using ParkBee.Models.Entities;
using System;
using System.Threading.Tasks;

namespace ParkBee.Services.Interfaces
{
    public interface IGaragesService
    {
        //ViewModels.CustomersList
        Task<Garage> Get(int pageIndex, int pageSize, string keyword = null);
        //ViewModels.CustomerDetails
        Garage GetCustomerById(Guid id);
        //ViewModels.Customer  ==== BindingModels.Customer
        Garage Add(object customerBindingModel);
        //BindingModels.Customer
        bool Update(object customerBindingModel);
        bool Delete(Guid id);
    }
}
