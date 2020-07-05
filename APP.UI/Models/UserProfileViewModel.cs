using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.UI.Models
{
    public class UserProfileViewModel
    {
        public ApplicationUser ApplicationUser { get; set; }
        public OrderOffers Offer { get; set; }
    }
}
