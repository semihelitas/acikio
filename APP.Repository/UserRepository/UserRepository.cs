using APP.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Repository.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersByCategory(string category)
        {
            return await _dbContext
                            .Users
                            .Where(x => x.Categories.Contains(category))
                            .AsNoTracking()
                            .ToListAsync();
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersBySearch(string location, string keyword)
        {
            if (location != null && keyword != null)
            {
                return await _dbContext
                                .Users
                                .Where(x => x.Location.Contains(location))
                                .Where(x => x.Categories.Contains(keyword) || x.AboutMe.Contains(keyword) || x.Nickname.Contains(keyword))
                                .AsNoTracking()
                                .OrderByDescending(x=>x.Rating)
                                .ToListAsync();
            }
            else if (location != null && keyword == null)
            {
                return await _dbContext
                                .Users
                                .Where(x => x.Location.Contains(location))
                                .AsNoTracking()
                                .OrderByDescending(x => x.Rating)
                                .ToListAsync();
            }
            else if (location == null && keyword != null)
            {
                return await _dbContext
                                .Users
                                .Where(x => x.Location.Contains(location))
                                .AsNoTracking()
                                .OrderByDescending(x => x.Rating)
                                .ToListAsync();
            }
            else
            {
                return await _dbContext
                                .Users
                                .AsNoTracking()
                                .OrderByDescending(x => x.Rating)
                                .ToListAsync();
            }
        }
    }
}
