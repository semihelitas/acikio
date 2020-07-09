using System;
using System.Collections.Generic;
using System.Text;

namespace APP.Core.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string SenderId { get; set; }
        public string ReceiverId { get; set; }
        public string MessageText { get; set; }
        public bool IsItRead { get; set; }
        public DateTime SentAt { get; set; }
    }
}
