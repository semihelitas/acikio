using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APP.UI.Models;
using APP.Service.Abstract;

namespace APP.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IChiefAdsService _chiefAdsService;

        public HomeController(ILogger<HomeController> logger, IChiefAdsService chiefAdsService)
        {
            _logger = logger;
            _chiefAdsService = chiefAdsService;
        }

        public async Task<IActionResult> Index()
        {
            var model = new HomeIndexViewModel()
            {
                ChiefAdvertisements = await _chiefAdsService.GetChiefAds(),
            };
            return View(model);
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
