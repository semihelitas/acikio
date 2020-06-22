using APP.Core.Models;
using APP.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Repository.FoodAds
{
    public class FoodAdsRepository : GenericRepository<FoodAdvertisement>, IFoodAdsRepository
    {
        public FoodAdsRepository(ApplicationDbContext context) : base(context) { }
    }
}
