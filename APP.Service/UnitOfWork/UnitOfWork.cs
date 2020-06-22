using APP.Core.Models;
using APP.Repository;
using APP.Repository.FoodAds;
using APP.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APP.Service.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<Type, object> repositories;

        public ApplicationDbContext _dbContext;
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IGenericRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class, IBaseEntity
        {
            if (repositories == null)
            {
                repositories = new Dictionary<Type, object>();
            }

            var type = typeof(TEntity);
            if (!repositories.ContainsKey(type))
            {
                repositories[type] = new GenericRepository<TEntity>(_dbContext);
            }

            return (IGenericRepository<TEntity>)repositories[type];
        }

        public async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
