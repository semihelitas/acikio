using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace APP.Core.Models
{
    public class Deal : IBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public OrderOffers Offer { get; set; }
        public DateTime DeliveryTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public bool IsCanceled { get; set; }
        public bool IsChiefConfirm { get; set; }
        public bool IsClientConfirm { get; set; }

    }
}
