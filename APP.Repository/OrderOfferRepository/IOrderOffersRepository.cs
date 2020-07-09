using APP.Core.Models;
using APP.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Repository.OrderOfferRepository
{
    public interface IOrderOffersRepository : IGenericRepository<OrderOffers>
    {
        Task<IEnumerable<OrderOffers>> GetAllOrderOffersOfUser(ApplicationUser user);
        Task<IEnumerable<OrderOffers>> GetAllOrderOffersOfUserSent(ApplicationUser user);
        Task<IEnumerable<OrderOffers>> GetOrderOffersOnlyChiefAccepted(ApplicationUser user);
        Task<IEnumerable<OrderOffers>> GetOrderOffersPendingClientResponse(ApplicationUser user);
    }
}
