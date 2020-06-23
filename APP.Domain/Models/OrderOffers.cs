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

        // Advertisement (başvurulan ilan)
        [ForeignKey("ChiefAdvertisement")]
        public Guid ChiefAdsId { get; set; }
        public ChiefAdvertisement ChiefAdvertisement { get; set; }

        // Client (başvuran)
        [ForeignKey("ApplicationUser")]
        public string ClientId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        // Teklif İçeriği/Mesajı
        public string OfferDescription { get; set; }

        // Teklif Edilen Fiyat
        public int OfferPrice { get; set; }

        // Teklif Tarihi
        public DateTime CreatedAt { get; set; }

        public bool IsAccepted { get; set; }
    }
}
