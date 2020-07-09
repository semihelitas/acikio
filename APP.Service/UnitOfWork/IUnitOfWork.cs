using APP.Repository.CategoryRepository;
using APP.Repository.DealRepository;
using APP.Repository.NotificationRepository;
using APP.Repository.OrderOfferRepository;
using APP.Repository.UserRepository;
using System.Threading.Tasks;

namespace APP.Service.UnitOfWork
{
    public interface IUnitOfWork
    { 
        IUserRepository Users { get; set; }
        IDealRepository Deals { get; set; }
        IOrderOffersRepository Offers { get; set; }
        ICategoryRepository Categories { get; set; }
        INotificationRepository Notifications { get; set; }
        Task<int> CommitAsync();
    }
}
