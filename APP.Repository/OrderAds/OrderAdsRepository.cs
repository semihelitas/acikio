using APP.Core.Models;
using APP.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace APP.Repository.OrderAds
{
    public class OrderAdsRepository : GenericRepository<OrderAdvertisement>, IOrderAdsRepository
    {
        public OrderAdsRepository(ApplicationDbContext context) : base(context) { }
    }
}
