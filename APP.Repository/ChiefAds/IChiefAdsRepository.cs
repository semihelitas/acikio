using APP.Core.Models;
using APP.Repository.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APP.Repository.ChiefAds
{
    public interface IChiefAdsRepository : IGenericRepository<ChiefAdvertisement>
    {
        Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location);
        Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location, string keyword);
        Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsByKeyword(string keyword);
        IEnumerable<ChiefAdvertisement> GetRandomChiefAdsFromTheLastest();
        List<ChiefAdvertisement> TakeTheLastXEntity(int number);
        Task<IEnumerable<ChiefAdvertisement>> GetAllChiefAdsOfSignedUser(ApplicationUser signedUser);
    }
}
