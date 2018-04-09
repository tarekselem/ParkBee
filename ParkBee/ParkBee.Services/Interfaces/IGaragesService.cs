using System;
using System.Threading.Tasks;

namespace ParkBee.Services.Interfaces
{
    public interface IGaragesService
    {
        Task<ViewModels.GarageList> Get(int pageIndex, int pageSize, string keyword = null);
        ViewModels.GarageDetails GetGarageById(Guid id);
        ViewModels.Garage Add(BindingModel.Garage garageBindingModel);
        bool Update(BindingModel.Garage garageBindingModel);
        bool Delete(Guid id);
    }
}
