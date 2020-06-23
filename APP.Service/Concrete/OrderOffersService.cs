using APP.Core.Models;
using APP.Repository.OrderOffer;
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
        public Task CreateOrderOffer(OrderOffers entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrderOffer(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderOffers>> GetAllOrderOffers()
        {
            throw new NotImplementedException();
        }

        public Task<OrderOffers> GetOrderOfferById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsOrderOfferExists(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderOffer(Guid id, OrderOffers entity)
        {
            throw new NotImplementedException();
        }
    }
}
