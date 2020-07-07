using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace APP.Core.Models
{
    public class OrderOffers : IBaseEntity
    {
        // Teklif Numarası
        [Key]
        public Guid Id { get; set; }

        public string ClientId { get; set; }

        // Chief
        [ForeignKey("ApplicationUser")]
        public string ChiefId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime DeliveryTime { get; set; }
        public DateTime CreatedAt { get; set; }

        public bool IsClientAccepted { get; set; }
        public bool IsChiefAccepted { get; set; }
        public bool IsDeal { get; set; }
    }
}
