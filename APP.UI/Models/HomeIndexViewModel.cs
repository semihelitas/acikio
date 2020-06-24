using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.UI.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<ChiefAdvertisement> ChiefAdvertisements { get; set; }
        public IEnumerable<ChiefAdvertisement> TheLastestRandomChiefAds { get; set; }
    }
}
