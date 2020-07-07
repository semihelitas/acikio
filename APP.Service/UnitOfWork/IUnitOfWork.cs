using APP.Core.Models;
using APP.Repository.CategoryRepository;
using APP.Repository.ChiefAds;
using APP.Repository.DealRepository;
using APP.Repository.OrderOffer;
using APP.Repository.Repository;
using APP.Repository.UserRepository;
using System;
using System.Threading.Tasks;

namespace APP.Service.UnitOfWork
{
    public interface IUnitOfWork
    { 
        IChiefAdsRepository Advertisements { get; set; }
        IUserRepository Users { get; set; }
        IDealRepository Deals { get; set; }
        IOrderOffersRepository Offers { get; set; }
        ICategoryRepository Categories { get; set; }
        Task<int> CommitAsync();
    }
}
