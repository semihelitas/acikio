using APP.Core.Models;
using APP.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Repository.DealRepository
{
    public interface IDealRepository : IGenericRepository<Deal>
    {
        Task<IEnumerable<Deal>> ChiefDeals(ApplicationUser user);
        Task<IEnumerable<Deal>> ClientDeals(ApplicationUser user);
        Task CompleteDeal(CompletedDeal completedDeal);
        Task<IEnumerable<CompletedDeal>> ChiefCompletedDeals(ApplicationUser user);
        Task<IEnumerable<CompletedDeal>> ClientCompletedDeals(ApplicationUser user);
    }
}
