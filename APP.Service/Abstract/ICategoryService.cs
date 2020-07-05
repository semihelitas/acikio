using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Service.Abstract
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
        Task<IEnumerable<Category>> GetFirstNCategories(int n);
    }
}
