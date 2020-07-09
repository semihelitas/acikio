using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace APP.UI.Controllers
{
    public class NotificationController : Controller
    {
        private readonly INotificationService _notificationService;
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpPost]
        public async Task MarkAllAsRead(string userID)
        {
            await _notificationService.MarkAllAsRead(userID);
        }

        [HttpPost]
        public async Task MarkSingleNotificationAsRead(Guid notificationId)
        {
            await _notificationService.MarkSingleNotificationAsRead(notificationId);
        }
    }
}
