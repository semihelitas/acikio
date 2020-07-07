using APP.Core.Models;
using APP.Repository.Repository;
using Microsoft.AspNetCore.Server.IIS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Repository.DealRepository
{
    public class DealRepository : GenericRepository<Deal>, IDealRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DealRepository(ApplicationDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task CompleteDeal(CompletedDeal competedDeal)
        {
            if (competedDeal !=null)
            {
                await _dbContext.CompletedDeal.AddAsync(competedDeal);
            }
        }

        public async Task<IEnumerable<Deal>> ChiefDeals(ApplicationUser user)
        {
            var deals = await _dbContext.Deal
                .Where(x => x.ChiefId == user.Id && x.IsDone == false)
                .Include(y => y.ApplicationUser)
                .Include(z => z.OrderOffer)
                .AsNoTracking()
                .ToListAsync();
            return deals;
        }

        public async Task<IEnumerable<Deal>> ClientDeals(ApplicationUser user)
        {
            var deals = await _dbContext.Deal
                .Where(x => x.OrderOffer.ClientId == user.Id && x.IsDone == false)
                .Include(y => y.ApplicationUser)
                .Include(z => z.OrderOffer)
                .AsNoTracking()
                .ToListAsync();
            return deals;
        }

        public async Task<IEnumerable<CompletedDeal>> ChiefCompletedDeals(ApplicationUser user)
        {
            var completedDeals = await _dbContext.CompletedDeal
                .Where(x => x.Deal.ChiefId == user.Id)
                .Include(y => y.Deal)
                .ThenInclude(z=>z.OrderOffer)
                .AsNoTracking()
                .ToListAsync();
            return completedDeals;
        }

        public async Task<IEnumerable<CompletedDeal>> ClientCompletedDeals(ApplicationUser user)
        {
            var completedDeals = await _dbContext.CompletedDeal
                .Where(x => x.Deal.OrderOffer.ClientId == user.Id)
                .Include(y => y.Deal)
                .ThenInclude(z => z.OrderOffer)
                .AsNoTracking()
                .ToListAsync();
            return completedDeals;
        }
    }
}
