using APP.Core.Models;
using APP.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Repository.ChiefAds
{
    public class ChiefAdsRepository : GenericRepository<ChiefAdvertisement>, IChiefAdsRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ChiefAdsRepository(ApplicationDbContext context) : base(context) 
        {
            _dbContext = context;
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location)
        {
            return await _dbContext.ChiefAdvertisement.Include(u=>u.ApplicationUser).Where(x => x.ApplicationUser.Location.Contains(location)).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location, string keyword)
        {
            return await _dbContext.ChiefAdvertisement.Include(u => u.ApplicationUser).Where(x => x.ApplicationUser.Location.Contains(location) && (x.Title.Contains(keyword) || x.Description.Contains(keyword) || x.Category.Contains(keyword))).ToListAsync();
        }
    }
}
