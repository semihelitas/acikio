using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Service.Abstract
{
    public interface IDealService
    {
        Task<IEnumerable<Deal>> GetDeals();
        Task<Deal> GetDealById(Guid id);
        Task CreateDeal(Deal entity);
        Task UpdateDeal(Guid id, Deal entity);
        Task DeleteDeal(Guid id);
        Task<bool> IsDealExists(Guid id);
        Task<IEnumerable<Deal>> ChiefDeals(ApplicationUser user);
        Task<IEnumerable<Deal>> ClientDeals(ApplicationUser user);
        Task CompleteDeal(CompletedDeal competedDeal);
        Task<IEnumerable<CompletedDeal>> ChiefCompletedDeals(ApplicationUser user);
        Task<IEnumerable<CompletedDeal>> ClientCompletedDeals(ApplicationUser user);
        Task<CompletedDeal> GetSingleCompletedDeal(Guid id);
    }
}
