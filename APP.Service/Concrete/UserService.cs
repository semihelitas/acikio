using APP.Core.Models;
using APP.Service.Abstract;
using APP.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Service.Concrete
{
    public class UserService : IUserService
    {
        private IUnitOfWork _uow;
        public UserService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersByCategory(string category)
        {
            return await _uow.Users.GetUsersByCategory(category);
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersBySearch(string location, string keyword)
        {
            return await _uow.Users.GetUsersBySearch(location, keyword);
        }
    }
}
