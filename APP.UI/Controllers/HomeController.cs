using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APP.UI.Models;
using APP.Repository;
using Microsoft.EntityFrameworkCore;
using APP.Service.Abstract;
using APP.Repository.Repository;
using APP.Core.Models;
using APP.Repository.FoodAds;

namespace APP.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFoodAdsService _foodAdsService;
        public HomeController(ILogger<HomeController> logger, IFoodAdsService foodAdsService)
        {
            _logger = logger;
            _foodAdsService = foodAdsService;
        }

        public async Task<IActionResult> Index()
        {
            var foodlist = await _foodAdsService.GetFoodAds();
            return View(foodlist);
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
