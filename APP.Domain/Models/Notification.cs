using System;
using System.Collections.Generic;
using System.Text;

namespace APP.Core.Models
{
    public class Notification
    {
        public Guid Id { get; set; }
        public string NotificationString { get; set; }
        public string SenderId { get; set; }
        public string SenderName { get; set; }
        public string ReceiverId { get; set; }
        public bool IsItRead { get; set; }
        public string ReturnUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
