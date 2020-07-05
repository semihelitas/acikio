using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Repository.UserRepository
{
    public interface IUserRepository
    {
        Task<IEnumerable<ApplicationUser>> GetUsersBySearch(string location, string keyword);
        Task<IEnumerable<ApplicationUser>> GetUsersByCategory(string category);
    }
}
