using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace APP.Core.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Location { get; set; }

        // PostedFoodAds: Oluşturulan "yemek yapan birini arıyorum" ilanlarını tutar.
        public ICollection<FoodAdvertisement> FoodAdvertisement { get; set; }

        // AppliedFoodAds: Başvurulan "bu yemeği yapabilirim" ilanlarını tutar.
        public ICollection<OrderAdvertisement> OrderAdvertisement { get; set; }
    }
}
