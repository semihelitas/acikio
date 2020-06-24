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

        public Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsByLocation(string city)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location)
        {
            return await _dbContext.ChiefAdvertisement.Include(u=>u.ApplicationUser).Where(x => x.ApplicationUser.Location.Contains(location)).AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetChiefAdsBySearch(string location, string keyword)
        {
            return await _dbContext.ChiefAdvertisement.Include(u => u.ApplicationUser).Where(x => x.ApplicationUser.Location.Contains(location) && (x.Title.Contains(keyword) || x.Description.Contains(keyword) || x.Category.Contains(keyword))).ToListAsync();
        }

        public List<ChiefAdvertisement> TakeTheLastXEntity(int number)
        {
            return _dbContext.ChiefAdvertisement.Include(x => x.ApplicationUser).OrderByDescending(x => x.CreatedAt).Take(number).ToList();
        }

        public IEnumerable<ChiefAdvertisement> GetRandomChiefAdsFromTheLastest()
        {
            var listCapacity =  _dbContext.ChiefAdvertisement.Count();
            if (listCapacity >= 10)
            {
                Random random = new Random();
                var takeLast10Entity = TakeTheLastXEntity(10);
                var randomFourEntity = new List<ChiefAdvertisement>();
                int theLastIndexCounter = 9;
                for (int i = 0; i < 4; i++)
                {
                    int number = random.Next(1, theLastIndexCounter);
                    randomFourEntity.Add(takeLast10Entity[number]);
                    takeLast10Entity.Remove(takeLast10Entity[number]);
                    theLastIndexCounter--;
                }
                return randomFourEntity;
            }
            else if(listCapacity < 4)
            {
                var takeAll = _dbContext.ChiefAdvertisement.Include(x => x.ApplicationUser).ToList();
                return takeAll;
            }
            else
            {
                var takeLast4Entity = TakeTheLastXEntity(4);
                return takeLast4Entity;
            }
        }

        public async Task<IEnumerable<ChiefAdvertisement>> GetAllChiefAdsOfSignedUser(ApplicationUser signedUser)
        {
            var adsListOfSignedUser = await _dbContext.ChiefAdvertisement.Where(x => x.ApplicationUser.Id == signedUser.Id).Include(x=>x.ApplicationUser).Include(x=>x.OrderOffers).AsNoTracking().ToListAsync();
            return adsListOfSignedUser;
        }
    }
}
