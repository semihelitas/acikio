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
using APP.Repository;

namespace APP.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IChiefAdsService _chiefAdsService;
        private readonly ICategoryService _categoryService;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, IChiefAdsService chiefAdsService, UserManager<ApplicationUser> userManager, ICategoryService categoryService)
        {
            _chiefAdsService = chiefAdsService;
            _categoryService = categoryService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _chiefAdsService.GetChiefAds();

            ViewBag.TotalAdsCount = list.Count();
            ViewBag.TotalUserCount = await _userManager.Users.CountAsync();
            ViewBag.IstanbulAdsCount = await GetAdsCountByLocation("İstanbul");
            ViewBag.AnkaraAdsCount = await GetAdsCountByLocation("Ankara");
            ViewBag.IzmirAdsCount = await GetAdsCountByLocation("İzmir");
            ViewBag.AdanaAdsCount = await GetAdsCountByLocation("Adana");

            var categories = await _categoryService.GetCategories();
            ViewBag.Categories = categories.Select(x => x.Name).ToList();

            var model = new HomeIndexViewModel()
            {
                HighestRatedUsers = await _userManager.Users.OrderByDescending(x => x.Rating).Take(6).ToListAsync(),
                Categories = await _categoryService.GetFirstNCategories(8),
            };
            return View(model);
        }

        public async Task<int> GetAdsCountByLocation(string location)
        {
            return await _userManager.Users.Where(x=>x.Location.Contains(location)).CountAsync();
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
