using APP.Core.Models;
using APP.Repository.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APP.Repository.ChiefAds
{
    public interface IChiefAdsRepository : IGenericRepository<ChiefAdvertisement>
    {
        Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location);
        Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsByLocation(string city);
        Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location, string keyword);
    }
}
