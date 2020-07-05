using APP.Core.Models;
using APP.Repository;
using APP.Repository.CategoryRepository;
using APP.Repository.ChiefAds;
using APP.Repository.OrderOffer;
using APP.Repository.Repository;
using APP.Repository.UserRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APP.Service.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        public ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Advertisements = new ChiefAdsRepository(_dbContext);
            Offers = new OrderOffersRepository(_dbContext);
            Categories = new CategoryRepository(_dbContext);
            Users = new UserRepository(_dbContext);
        }

        public IChiefAdsRepository Advertisements { get; set; }
        public IOrderOffersRepository Offers { get; set; }
        public ICategoryRepository Categories { get; set; }
        public IUserRepository Users { get; set; }

        public async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
