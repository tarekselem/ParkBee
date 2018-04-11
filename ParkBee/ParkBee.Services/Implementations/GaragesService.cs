using ParkBee.Data.Common;
using ParkBee.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LinqKit;
using System.Threading.Tasks;

namespace ParkBee.Services.Implementations
{
    public class GaragesService : IGaragesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GaragesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        ViewModels.Garage IGaragesService.Add(BindingModels.Garage garageBindingModel)
        {
            if (garageBindingModel == null) throw new ArgumentNullException(nameof(garageBindingModel));

            var garageEntity = AutoMapper.Mapper.Map<Entities.Garage>(garageBindingModel);
            var addedGarage = _unitOfWork.RepositoryFor<Entities.Garage>().Insert(garageEntity);
            _unitOfWork.SaveChanges();

            return AutoMapper.Mapper.Map<ViewModels.Garage>(addedGarage);
        }

        bool IGaragesService.Delete(Guid id)
        {
            if (Guid.Empty == id) throw new ArgumentNullException(nameof(id));

            bool result = _unitOfWork.RepositoryFor<Entities.Garage>().Delete(id);
            if (result) _unitOfWork.SaveChanges();

            return result;
        }

        async Task<ViewModels.GarageList> IGaragesService.Get(int pageIndex, int pageSize, string keyword)
        {
            var predicate = BuildSearchFilter(keyword);

            var items = await _unitOfWork.RepositoryFor<Entities.Garage>().GetAsync(garage => new ViewModels.Garage
            {
                Id = garage.Id,
                Name = garage.Name,
                Address = garage.Address,
                Status = garage.Status.ToString(),
                OwnerId = garage.OwnerId,
                OwnerName = garage.Owner.FullName,
                DoorsCount = garage.Doors.Count
            }, predicate, c => c.OrderBy(o => o.Id), null, pageIndex, pageSize);
            var total = _unitOfWork.RepositoryFor<Entities.Garage>().Get().Count();

            return new ViewModels.GarageList { Items = items, Total = total };
        }

        ViewModels.GarageDetails IGaragesService.GetGarageById(Guid id)
        {
            var includedProperties = new List<Expression<Func<Entities.Garage, object>>>() { c => c.Doors };
            var garageEntity = _unitOfWork.RepositoryFor<Entities.Garage>().Get(filter: c => c.Id == id, includedProperties: includedProperties).FirstOrDefault();

            if (garageEntity == null) return null;

            return AutoMapper.Mapper.Map<ViewModels.GarageDetails>(garageEntity);
        }

        bool IGaragesService.Update(BindingModels.Garage garageBindingModel)
        {
            if (garageBindingModel == null) throw new ArgumentNullException(nameof(garageBindingModel));

            var garageEntity = AutoMapper.Mapper.Map<Entities.Garage>(garageBindingModel);
            bool result = _unitOfWork.RepositoryFor<Entities.Garage>().Update(garageEntity);

            if (result) _unitOfWork.SaveChanges();

            return result;
        }

        #region Private Methods
        private ExpressionStarter<Entities.Garage> BuildSearchFilter(string keyword)
        {
            var predicate = PredicateBuilder.True<Entities.Garage>();

            if (!string.IsNullOrEmpty(keyword))
            {
                predicate = predicate.And(s => s.Address.ToLower().Contains(keyword.ToLower()));
                predicate = predicate.And(s => s.Name.ToLower().Contains(keyword.ToLower()));
            }

            return predicate;
        }
        #endregion
    }
}
