using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Core.Models;
using APP.Service.Abstract;
using APP.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace APP.UI.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICategoryService _categoryService;
        private readonly INotificationService _notificationService;
        private readonly IDealService _dealService;

        private UserManager<ApplicationUser> _userManager;
        public UserController(UserManager<ApplicationUser> userManager, IUserService userService, ICategoryService categoryService, INotificationService notificationService, IDealService dealService)
        {
            _userManager = userManager;
            _userService = userService;
            _categoryService = categoryService;
            _notificationService = notificationService;
            _dealService = dealService;
        }

        public async Task<IActionResult> Profile(string id)
        {
            await ShowNotifications();
            if (id == null)
                return NotFound();
            else
            {
                var user = await _userManager.FindByIdAsync(id);
                var deals = await _dealService.ChiefCompletedDeals(user);
                return View(new UserProfileViewModel() { ApplicationUser = user, CompletedDeals = deals });
            }
        }

        public async Task<IActionResult> Users(string location, string keyword)
        {
            await ShowNotifications();
            var categories = await _categoryService.GetCategories();
            ViewBag.Categories = categories.Select(x => x.Name).ToList();
            return View(await _userService.GetUsersBySearch(location, keyword));
        }

        public async Task<IActionResult> FilteredUsersByCategory(string category)
        {
            await ShowNotifications();
            var categories = await _categoryService.GetCategories();
            ViewBag.Categories = categories.Select(x => x.Name).ToList();
            return View(await _userService.GetUsersByCategory(category));
        }

        public async Task ShowNotifications()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            ViewBag.Notifications = await _notificationService.GetUnreadNotifications(currentUser.Id);
        }
    }
}
