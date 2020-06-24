using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APP.UI.Models;
using APP.Service.Abstract;
using System.Linq;
using APP.Core.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace APP.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IChiefAdsService _chiefAdsService;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, IChiefAdsService chiefAdsService, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _chiefAdsService = chiefAdsService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _chiefAdsService.GetChiefAds();

            ViewBag.TotalAdsCount = list.Count();
            ViewBag.TotalUserCount = await _userManager.Users.CountAsync();
            ViewBag.IstanbulAdsCount = GetAdsCountByLocation("İstanbul", list);
            ViewBag.AnkaraAdsCount = GetAdsCountByLocation("Ankara", list);
            ViewBag.IzmirAdsCount = GetAdsCountByLocation("İzmir", list);
            ViewBag.AdanaAdsCount = GetAdsCountByLocation("Adana", list);

            var model = new HomeIndexViewModel()
            {
                ChiefAdvertisements = list,
                TheLastestRandomChiefAds = _chiefAdsService.GetRandomChiefAdsFromTheLastest()
            };
            return View(model);
        }

        public int GetAdsCountByLocation(string location, IEnumerable<ChiefAdvertisement> list)
        {
            return list.Where(x => x.ApplicationUser.Location.Contains(location)).Count();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
