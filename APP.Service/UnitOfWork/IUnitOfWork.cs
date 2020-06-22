using APP.Core.Models;
using APP.Repository.FoodAds;
using APP.Repository.Repository;
using System.Threading.Tasks;

namespace APP.Service.UnitOfWork
{
    public interface IUnitOfWork
    { 
        IGenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IBaseEntity;
        Task<int> CommitAsync();
    }
}
