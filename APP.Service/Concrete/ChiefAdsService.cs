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
        private IChiefAdsRepository _chiefAdsRepository;

        public ChiefAdsService(IUnitOfWork uow, IChiefAdsRepository chiefAdsRepository)
        {
            _uow = uow;
            _chiefAdsRepository = chiefAdsRepository;
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetChiefAds()
        {
            return await _uow.GetRepository<ChiefAdvertisement>().GetAllAsync();
        }

        public async Task<ChiefAdvertisement> GetChiefAdsById(Guid id)
        {
            return await _uow.GetRepository<ChiefAdvertisement>().GetByIdAsync(id);
        }

        public async Task CreateChiefAds(ChiefAdvertisement entity)
        {
            await _uow.GetRepository<ChiefAdvertisement>().CreateAsync(entity);
            await _uow.CommitAsync();
        }

        public async Task UpdateChiefAds(Guid id, ChiefAdvertisement entity)
        {
            await _uow.GetRepository<ChiefAdvertisement>().UpdateAsync(id, entity);
            await _uow.CommitAsync();
        }

        public async Task DeleteChiefAds(Guid id)
        {
            await _uow.GetRepository<ChiefAdvertisement>().DeleteAsync(id);
            await _uow.CommitAsync();
        }

        public async Task<bool> IsChiefAdsExists(Guid id)
        {
            return await _uow.GetRepository<ChiefAdvertisement>().IsExists(id);
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location)
        {
            return await _chiefAdsRepository.GetChiefAdsBySearch(location);
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location, string keyword)
        {
            return await _chiefAdsRepository.GetChiefAdsBySearch(location, keyword);
        }

        public IEnumerable<ChiefAdvertisement> GetRandomChiefAdsFromTheLastest()
        {
            return _chiefAdsRepository.GetRandomChiefAdsFromTheLastest();
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetAllChiefAdsOfSignedUser(ApplicationUser signedUser)
        {
            return await _chiefAdsRepository.GetAllChiefAdsOfSignedUser(signedUser);
        }
    }
}
