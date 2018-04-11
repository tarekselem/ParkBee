using System;
using System.Threading.Tasks;

namespace ParkBee.Services.Interfaces
{
    public interface IDoorsService
    {
        Task<ViewModels.GarageList> Get(int pageIndex, int pageSize, string keyword = null);
        ViewModels.GarageDetails GetDoorById(Guid id);
        ViewModels.Garage Add(BindingModels.Garage garageBindingModel);
        bool Update(BindingModels.Garage garageBindingModel);
        bool Delete(Guid id);
        bool IsDoorOnline(Guid doorId);
    }
}
