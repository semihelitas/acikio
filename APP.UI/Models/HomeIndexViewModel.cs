using APP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APP.UI.Models
{
    public class HomeIndexViewModel
    {
        public IEnumerable<ApplicationUser> HighestRatedUsers { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
