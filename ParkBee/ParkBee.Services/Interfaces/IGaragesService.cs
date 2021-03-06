﻿using System;
using System.Threading.Tasks;

namespace ParkBee.Services.Interfaces
{
    public interface IGaragesService
    {
        Task<ViewModels.GarageList> Get(int pageIndex, int pageSize, string keyword = null);
        ViewModels.GarageDetails GetGarageById(Guid id);
        ViewModels.Garage Add(BindingModels.Garage garageBindingModel);
        bool Update(BindingModels.Garage garageBindingModel);
        bool Delete(Guid id);
    }
}
