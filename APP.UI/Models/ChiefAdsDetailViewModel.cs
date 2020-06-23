using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.UI.Models
{
    public class ChiefAdsDetailViewModel
    {
        public ChiefAdvertisement ChiefAdvertisement { get; set; }
        public IEnumerable<OrderOffers> Teklifler { get; set; }
    }
}
