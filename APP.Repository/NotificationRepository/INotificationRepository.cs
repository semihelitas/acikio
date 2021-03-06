﻿using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APP.Repository.NotificationRepository
{
    public interface INotificationRepository
    {
        Task SendNotification(Notification notification);
        Task MarkAllAsRead(string userId);
        Task MarkSingleNotificationAsRead(Guid notificationId);
        Task<IEnumerable<Notification>> GetAllNotifications(string userId);
        Task<IEnumerable<Notification>> GetUnreadNotifications(string userId);
    }
}
