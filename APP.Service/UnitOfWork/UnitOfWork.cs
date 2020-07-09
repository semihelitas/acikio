using APP.Core.Models;
using APP.Repository;
using APP.Repository.CategoryRepository;
using APP.Repository.DealRepository;
using APP.Repository.NotificationRepository;
using APP.Repository.OrderOfferRepository;
using APP.Repository.UserRepository;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace APP.Service.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        public ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Offers = new OrderOffersRepository(_dbContext);
            Categories = new CategoryRepository(_dbContext);
            Users = new UserRepository(_dbContext);
            Deals = new DealRepository(_dbContext);
            Notifications = new NotificationRepository(_dbContext);
        }

        public IOrderOffersRepository Offers { get; set; }
        public ICategoryRepository Categories { get; set; }
        public IUserRepository Users { get; set; }
        public IDealRepository Deals { get; set; }
        public INotificationRepository Notifications { get; set; }

        public async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
