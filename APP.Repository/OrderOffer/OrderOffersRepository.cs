using APP.Core.Models;
using APP.Repository.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Repository.OrderOffer
{
    public class OrderOffersRepository : GenericRepository<OrderOffers>, IOrderOffersRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public OrderOffersRepository(ApplicationDbContext context) : base(context)
        {
            _dbContext = context;
        }

        // Offers which chief receive
        public async Task<IEnumerable<OrderOffers>> GetAllOrderOffersOfUser(ApplicationUser user)
        {
            var data = await _dbContext.OrderOffers
                .Include(y => y.ApplicationUser)
                .Where(z => z.ChiefId == user.Id && z.IsChiefAccepted == false && z.IsClientAccepted == false)
                .AsNoTracking()
                .ToListAsync();
            return data;
        }

        // Offers which client sent
        public async Task<IEnumerable<OrderOffers>> GetAllOrderOffersOfUserSent(ApplicationUser user)
        {
            var data = await _dbContext.OrderOffers
                .Include(y => y.ApplicationUser)
                .Where(z => z.ClientId == user.Id && z.IsChiefAccepted == false && z.IsClientAccepted == false)
                .AsNoTracking()
                .ToListAsync();
            return data;
        }

        // Offers which chief accepted
        public async Task<IEnumerable<OrderOffers>> GetOrderOffersOnlyChiefAccepted(ApplicationUser user)
        {
            var data = await _dbContext.OrderOffers
                .Include(x => x.ApplicationUser)
                .Where(y => y.ChiefId == user.Id && y.IsChiefAccepted == true && y.IsClientAccepted == false)
                .AsNoTracking()
                .ToListAsync();
            return data;
        }

        // Offers which pending client response <last-stage> 
        public async Task<IEnumerable<OrderOffers>> GetOrderOffersPendingClientResponse(ApplicationUser user)
        {
            var data = await _dbContext.OrderOffers
                .Include(x => x.ApplicationUser)
                .Where(y => y.ClientId == user.Id && y.IsChiefAccepted == true && y.IsClientAccepted == false)
                .AsNoTracking()
                .ToListAsync();
            return data;
        }
    }
}
