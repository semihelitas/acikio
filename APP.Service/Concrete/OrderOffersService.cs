using APP.Core.Models;
using APP.Service.Abstract;
using APP.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APP.Service.Concrete
{
    public class OrderOffersService : IOrderOffersService
    {
        private IUnitOfWork _uow;

        public OrderOffersService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task CreateOrderOffer(OrderOffers entity)
        {
            await _uow.Offers.CreateAsync(entity);
        }

        public async Task<int> CommitAsync()
        {
            return await _uow.CommitAsync();
        }

        public async Task<IEnumerable<OrderOffers>> GetAllOrderOffersOfUser(ApplicationUser user)
        {
            return await _uow.Offers.GetAllOrderOffersOfUser(user);
        }

        public async Task<IEnumerable<OrderOffers>> GetAllOrderOffersOfUserSent(ApplicationUser user)
        {
            return await _uow.Offers.GetAllOrderOffersOfUserSent(user);
        }

        public async Task<OrderOffers> GetOrderOfferById(Guid id)
        {
            return await _uow.Offers.GetByIdAsync(id);
        }

        public async Task<IEnumerable<OrderOffers>> GetGetOrderOffersOnlyChiefAccepted(ApplicationUser user)
        {
            return await _uow.Offers.GetOrderOffersOnlyChiefAccepted(user);
        }

        public async Task DeleteOrderOffer(Guid id)
        {
            await _uow.Offers.DeleteAsync(id);
        }

        public async Task<IEnumerable<OrderOffers>> GetOrderOffersPendingClientResponse(ApplicationUser user)
        {
            return await _uow.Offers.GetOrderOffersPendingClientResponse(user);
        }

        public Task<bool> IsOrderOfferExists(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderOffer(Guid id, OrderOffers entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderOffers>> GetAllOrderOffers()
        {
            throw new NotImplementedException();
        }
    }
}
