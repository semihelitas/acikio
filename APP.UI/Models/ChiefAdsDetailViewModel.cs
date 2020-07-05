using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APP.UI.Models
{
    public class ChiefAdsDetailViewModel
    {
        public ChiefAdvertisement Advertisement { get; set; }
        public OrderOffers Offer { get; set; }
    }
}
