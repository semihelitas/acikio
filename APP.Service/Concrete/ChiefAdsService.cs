using APP.Core.Models;
using APP.Repository.ChiefAds;
using APP.Service.Abstract;
using APP.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Service.Concrete
{
    public class ChiefAdsService : IChiefAdsService
    {
        private IUnitOfWork _uow;
        public ChiefAdsService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetChiefAds()
        {
            return await _uow.Advertisements.GetAllAsync();
        }

        public async Task<ChiefAdvertisement> GetChiefAdsById(Guid id)
        {
            return await _uow.Advertisements.GetByIdAsync(id);
        }

        public async Task CreateChiefAds(ChiefAdvertisement entity)
        {
            await _uow.Advertisements.CreateAsync(entity);
            await _uow.CommitAsync();
        }

        public async Task UpdateChiefAds(Guid id, ChiefAdvertisement entity)
        {
            await _uow.Advertisements.UpdateAsync(id, entity);
            await _uow.CommitAsync();
        }

        public async Task DeleteChiefAds(Guid id)
        {
            await _uow.Advertisements.DeleteAsync(id);
            await _uow.CommitAsync();
        }

        public async Task<bool> IsChiefAdsExists(Guid id)
        {
            return await _uow.Advertisements.IsExists(id);
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location)
        {
            return await _uow.Advertisements.GetChiefAdsBySearch(location);
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location, string keyword)
        {
            return await _uow.Advertisements.GetChiefAdsBySearch(location, keyword);
        }

        public IEnumerable<ChiefAdvertisement> GetRandomChiefAdsFromTheLastest()
        {
            return _uow.Advertisements.GetRandomChiefAdsFromTheLastest();
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetAllChiefAdsOfSignedUser(ApplicationUser signedUser)
        {
            return await _uow.Advertisements.GetAllChiefAdsOfSignedUser(signedUser);
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsByKeyword(string keyword)
        {
            return await _uow.Advertisements.GetChiefAdsByKeyword(keyword);
        }
    }
}
