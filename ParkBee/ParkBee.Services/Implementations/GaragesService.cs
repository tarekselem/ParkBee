using ParkBee.Data.Common;
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

        ViewModels.Garage IGaragesService.Add(BindingModel.Garage garageBindingModel)
        {
            if (garageBindingModel == null) throw new ArgumentNullException(nameof(garageBindingModel));

            var garageEntity = AutoMapper.Mapper.Map<Entities.Garage>(garageBindingModel);
            var addedGarage = _unitOfWork.RepositoryFor<Entities.Garage>().Insert(garageEntity);
            _unitOfWork.SaveChanges();

            return AutoMapper.Mapper.Map<ViewModels.Garage>(addedGarage);
        }

        bool IGaragesService.Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<ViewModels.GarageList> IGaragesService.Get(int pageIndex, int pageSize, string keyword)
        {
            throw new NotImplementedException();
        }

        ViewModels.GarageDetails IGaragesService.GetCustomerById(Guid id)
        {
            throw new NotImplementedException();
        }

        bool IGaragesService.Update(BindingModel.Garage customerBindingModel)
        {
            throw new NotImplementedException();
        }
    }
}
