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
        private UserManager<ApplicationUser> _userManager;
        public UserController(UserManager<ApplicationUser> userManager, IUserService userService, ICategoryService categoryService)
        {
            _userManager = userManager;
            _userService = userService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Profile(string id)
        {
            if (id == null)
                return NotFound();
            else
            {
                var user = await _userManager.FindByIdAsync(id);
                return View(new UserProfileViewModel() { ApplicationUser = user });
            }
        }

        public async Task<IActionResult> Users(string location, string keyword)
        {
            var categories = await _categoryService.GetCategories();
            ViewBag.Categories = categories.Select(x => x.Name).ToList();
            return View(await _userService.GetUsersBySearch(location, keyword));
        }

        public async Task<IActionResult> FilteredUsersByCategory(string category)
        {
            var categories = await _categoryService.GetCategories();
            ViewBag.Categories = categories.Select(x => x.Name).ToList();
            return View(await _userService.GetUsersByCategory(category));
        }
    }
}
