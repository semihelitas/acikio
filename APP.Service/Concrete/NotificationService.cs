using APP.Core.Models;
using APP.Service.Abstract;
using APP.Service.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Service.Concrete
{
    public class NotificationService : INotificationService
    {
        private IUnitOfWork _uow;
        public NotificationService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<IEnumerable<Notification>> GetAllNotifications(string userId)
        {
            return await _uow.Notifications.GetAllNotifications(userId);
        }

        public async Task<IEnumerable<Notification>> GetUnreadNotifications(string userId)
        {
            return await _uow.Notifications.GetUnreadNotifications(userId);
        }

        public async Task MarkAllAsRead(string userId)
        {
            await _uow.Notifications.MarkAllAsRead(userId);
        }

        public async Task MarkSingleNotificationAsRead(Guid notificationId)
        {
            await _uow.Notifications.MarkSingleNotificationAsRead(notificationId);
        }

        public async Task SendNotification(Notification notification)
        {
            await _uow.Notifications.SendNotification(notification);
        }
    }
}
