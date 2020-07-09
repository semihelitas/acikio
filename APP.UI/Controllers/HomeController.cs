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
using Microsoft.AspNetCore.Authorization;

namespace APP.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOrderOffersService _orderOffersService;
        private readonly ICategoryService _categoryService;
        private readonly INotificationService _notificationService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public HomeController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ICategoryService categoryService, IOrderOffersService orderOffersService, INotificationService notificationService, SignInManager<ApplicationUser> signInManager)
        {
            _categoryService = categoryService;
            _orderOffersService = orderOffersService;
            _userManager = userManager;
            _notificationService = notificationService;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);
                ViewBag.Notifications = await _notificationService.GetUnreadNotifications(user.Id);
            }

            ViewBag.TotalUserCount = await _userManager.Users.CountAsync();
            ViewBag.IstanbulAdsCount = await GetChefCountByLocation("İstanbul");
            ViewBag.AnkaraAdsCount = await GetChefCountByLocation("Ankara");
            ViewBag.IzmirAdsCount = await GetChefCountByLocation("İzmir");
            ViewBag.AdanaAdsCount = await GetChefCountByLocation("Adana");

            var categories = await _categoryService.GetCategories();
            ViewBag.Categories = categories.Select(x => x.Name).ToList();
            var chefUsers = await _userManager.GetUsersInRoleAsync("Usta");
            var model = new HomeIndexViewModel()
            {
                HighestRatedUsers = chefUsers.OrderByDescending(x => x.Rating).Take(6).ToList(),
                Categories = await _categoryService.GetFirstNCategories(8),
            };
            return View(model);
        }

        public async Task<int> GetChefCountByLocation(string location)
        {
            if (_signInManager.IsSignedIn(User))
            {
                var user = await _userManager.GetUserAsync(User);
                ViewBag.Notifications = await _notificationService.GetUnreadNotifications(user.Id);
            }

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
