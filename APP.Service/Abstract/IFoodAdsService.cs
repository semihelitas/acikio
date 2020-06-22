using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Service.Abstract
{
    public interface IFoodAdsService
    {
        Task<IEnumerable<FoodAdvertisement>> GetFoodAds();
        Task<FoodAdvertisement> GetFoodAdsById(Guid id);
        Task CreateFoodAds(FoodAdvertisement entity);
        Task UpdateFoodAds(Guid id, FoodAdvertisement entity);
        Task DeleteFoodAds(Guid id);
        Task<bool> IsFoodAdsExists(Guid id);
    }
}
