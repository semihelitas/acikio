using APP.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Repository.NotificationRepository
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public NotificationRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Notification>> GetAllNotifications(string userId)
        {
            return await _dbContext.Notification.Where(x => x.ReceiverId == userId && x.IsItRead == false).OrderByDescending(x=>x.CreatedAt).ToListAsync();
        }

        public async Task<IEnumerable<Notification>> GetUnreadNotifications(string userId)
        {
            return await _dbContext.Notification.Where(x => x.ReceiverId == userId && x.IsItRead == false).ToListAsync();
        }

        public async Task MarkAllAsRead(string userId)
        {
            var notificationsOfUser = await _dbContext.Notification.Where(x => x.ReceiverId == userId && x.IsItRead == false).ToListAsync();

            foreach (var notification in notificationsOfUser)
            {
                notification.IsItRead = true;
            }

            await _dbContext.SaveChangesAsync();
        }

        public async Task MarkSingleNotificationAsRead(Guid notificationId)
        {
            var notification = await _dbContext.Notification.Where(x => x.Id == notificationId).FirstOrDefaultAsync();
            notification.IsItRead = true;
            await _dbContext.SaveChangesAsync();
        }

        public async Task SendNotification(Notification notification)
        {
            await _dbContext.Notification.AddAsync(notification);
            await _dbContext.SaveChangesAsync();
        }
    }
}
