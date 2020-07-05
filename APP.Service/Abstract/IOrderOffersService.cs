using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Service.Abstract
{
    public interface IOrderOffersService
    {
        Task<IEnumerable<OrderOffers>> GetAllOrderOffers();
        Task<OrderOffers> GetOrderOfferById(Guid id);
        Task CreateOrderOffer(OrderOffers entity);
        Task UpdateOrderOffer(Guid id, OrderOffers entity);
        Task DeleteOrderOffer(Guid id);
        Task<bool> IsOrderOfferExists(Guid id);
        Task<IEnumerable<OrderOffers>> GetAllOrderOffersOfUser(ApplicationUser user);
        Task<IEnumerable<OrderOffers>> GetAllOrderOffersOfUserSent(ApplicationUser user);
        Task<IEnumerable<OrderOffers>> GetGetOrderOffersOnlyChiefAccepted(ApplicationUser user);
        Task<IEnumerable<OrderOffers>> GetOrderOffersPendingClientResponse(ApplicationUser user);
        Task<int> CommitAsync();
    }
}
