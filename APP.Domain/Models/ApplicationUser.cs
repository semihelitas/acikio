using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace APP.Core.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public double Rating { get; set; }
        public string Image { get; set; }
        public string Nickname { get; set; }
        public double MinimumOrderPrice { get; set; }
        public string Categories { get; set; }
        public ICollection<OrderOffers> OrderOffers { get; set; }
    }
}
