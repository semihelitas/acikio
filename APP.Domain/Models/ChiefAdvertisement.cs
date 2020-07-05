using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace APP.Core.Models
{
    public class ChiefAdvertisement : IBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int AdViewed { get; set; }

        // User
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public DateTime CreatedAt { get; set; }

        // İlana Gelen Teklifler
        public ICollection<OrderOffers> OrderOffers { get; set; }

    }
}
