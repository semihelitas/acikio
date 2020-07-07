using System;
using System.Collections.Generic;
using System.Text;

namespace APP.Core.Models
{
    public class CompletedDeal
    {
        public Guid Id { get; set; }
        public Deal Deal { get; set; }
        public double DeliciousScore { get; set; }
        public double TimingScore { get; set; }
        public double CommunicationScore { get; set; }
        public double AdviceScore { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
