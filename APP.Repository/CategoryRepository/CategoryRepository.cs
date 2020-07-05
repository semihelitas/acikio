using APP.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Repository.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _dbContext.Category.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Category>> GetFirstNCategories(int n)
        {
            return await _dbContext.Category.Take(n).AsNoTracking().ToListAsync();
        }
    }
}
