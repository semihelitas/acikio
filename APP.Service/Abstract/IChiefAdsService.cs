using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Service.Abstract
{
    public interface IChiefAdsService
    {
        Task<IEnumerable<ChiefAdvertisement>> GetChiefAds();
        Task<ChiefAdvertisement> GetChiefAdsById(Guid id);
        Task CreateChiefAds(ChiefAdvertisement entity);
        Task UpdateChiefAds(Guid id, ChiefAdvertisement entity);
        Task DeleteChiefAds(Guid id);
        Task<bool> IsChiefAdsExists(Guid id);
        Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location);
        Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location, string keyword);
        IEnumerable<ChiefAdvertisement> GetRandomChiefAdsFromTheLastest();
        Task<IEnumerable<ChiefAdvertisement>> GetAllChiefAdsOfSignedUser(ApplicationUser signedUser);
    }
}
