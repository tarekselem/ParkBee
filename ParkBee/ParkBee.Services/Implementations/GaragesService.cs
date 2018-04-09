using ParkBee.Data.Common;
using ParkBee.Models.Entities;
using ParkBee.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParkBee.Services.Implementations
{
    public class GaragesService:IGaragesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GaragesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        Garage IGaragesService.Add(object customerBindingModel)
        {
            throw new NotImplementedException();
        }

        bool IGaragesService.Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<Garage> IGaragesService.Get(int pageIndex, int pageSize, string keyword)
        {
            throw new NotImplementedException();
        }

        Garage IGaragesService.GetCustomerById(Guid id)
        {
            throw new NotImplementedException();
        }

        bool IGaragesService.Update(object customerBindingModel)
        {
            throw new NotImplementedException();
        }
    }
}
