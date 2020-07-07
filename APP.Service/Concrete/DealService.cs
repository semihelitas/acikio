using APP.Core.Models;
using APP.Service.Abstract;
using APP.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Service.Concrete
{
    public class DealService : IDealService
    {
        private IUnitOfWork _uow;
        public DealService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Deal>> ChiefDeals(ApplicationUser user)
        {
            return await _uow.Deals.ChiefDeals(user);
        }

        public async Task<IEnumerable<Deal>> ClientDeals(ApplicationUser user)
        {
            return await _uow.Deals.ClientDeals(user);
        }

        public async Task CreateDeal(Deal entity)
        {
            await _uow.Deals.CreateAsync(entity);
        }

        public async Task CompleteDeal(CompletedDeal competedDeal)
        {
            await _uow.Deals.CompleteDeal(competedDeal);
        }

        public async Task<IEnumerable<CompletedDeal>> ChiefCompletedDeals(ApplicationUser user)
        {
            return await _uow.Deals.ChiefCompletedDeals(user);
        }

        public async Task<IEnumerable<CompletedDeal>> ClientCompletedDeals(ApplicationUser user)
        {
            return await _uow.Deals.ClientCompletedDeals(user);
        }

        public Task DeleteDeal(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Deal> GetDealById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Deal>> GetDeals()
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsDealExists(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDeal(Guid id, Deal entity)
        {
            throw new NotImplementedException();
        }
    }
}
