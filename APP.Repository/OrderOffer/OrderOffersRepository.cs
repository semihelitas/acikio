using APP.Core.Models;
using APP.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace APP.Repository.OrderOffer
{
    public class OrderOffersRepository : GenericRepository<OrderOffers>, IOrderOffersRepository
    {
        public OrderOffersRepository(ApplicationDbContext context) : base(context) { }
    }
}
