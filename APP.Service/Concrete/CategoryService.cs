using APP.Core.Models;
using APP.Service.Abstract;
using APP.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Service.Concrete
{
    public class CategoryService : ICategoryService
    {
        private IUnitOfWork _uow;
        public CategoryService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _uow.Categories.GetCategories();
        }

        public async Task<IEnumerable<Category>> GetFirstNCategories(int n)
        {
            return await _uow.Categories.GetFirstNCategories(n);
        }
    }
}
