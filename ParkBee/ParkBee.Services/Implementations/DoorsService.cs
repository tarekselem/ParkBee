using ParkBee.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace ParkBee.Services.Implementations
{
    public class DoorsService : IDoorsService
    {
        public ViewModels.Garage Add(BindingModels.Garage garageBindingModel)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<GarageList> Get(int pageIndex, int pageSize, string keyword = null)
        {
            throw new NotImplementedException();
        }

        public GarageDetails GetDoorById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IsDoorOnline(Guid doorId)
        {
            throw new NotImplementedException();
        }

        public bool Update(BindingModels.Garage garageBindingModel)
        {
            throw new NotImplementedException();
        }
    }
}
