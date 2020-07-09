using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.UI.Models
{
    public class MessageInboxViewModel
    {
        public IEnumerable<ApplicationUser> ChatUsers { get; set; }
        public IEnumerable<Message> Conversations { get; set; }
    }
}
