using APP.Core.Models;
using APP.Repository.FoodAds;
using APP.Service.Abstract;
using APP.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Service.Concrete
{
    public class FoodAdsService : IFoodAdsService
    {
        private IUnitOfWork _uow;

        public FoodAdsService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<FoodAdvertisement>> GetFoodAds()
        {
            return await _uow.GetRepository<FoodAdvertisement>().GetAllAsync();
        }

        public async Task<FoodAdvertisement> GetFoodAdsById(Guid id)
        {
            return await _uow.GetRepository<FoodAdvertisement>().GetByIdAsync(id);
        }

        public async Task CreateFoodAds(FoodAdvertisement entity)
        {
            await _uow.GetRepository<FoodAdvertisement>().CreateAsync(entity);
            await _uow.CommitAsync();
        }

        public async Task UpdateFoodAds(Guid id, FoodAdvertisement entity)
        {
            await _uow.GetRepository<FoodAdvertisement>().UpdateAsync(id, entity);
            await _uow.CommitAsync();
        }

        public async Task DeleteFoodAds(Guid id)
        {
            await _uow.GetRepository<FoodAdvertisement>().DeleteAsync(id);
            await _uow.CommitAsync();
        }

        public async Task<bool> IsFoodAdsExists(Guid id)
        {
            return await _uow.GetRepository<FoodAdvertisement>().IsExists(id);
        }


    }
}
