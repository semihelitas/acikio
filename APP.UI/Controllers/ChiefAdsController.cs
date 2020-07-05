using System;
using System.Linq;
using System.Threading.Tasks;
using APP.Core.Models;
using APP.Repository;
using APP.Service.Abstract;
using APP.UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP.UI.Controllers
{
    [Authorize]
    public class ChiefAdsController : Controller
    {
        private readonly IChiefAdsService _chiefAdsService;
        private UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _db;
        public ChiefAdsController(IChiefAdsService chiefAdsService, UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _chiefAdsService = chiefAdsService;
            _userManager = userManager;
            _db = db;
        }

        // GET: /usta-ilanlari
        public async Task<IActionResult> Index(string location, string keyword)
        {
            if (location != null && keyword != null)
            {
                ViewBag.Location = location;
                ViewBag.Keyword = keyword;
                return View(await _chiefAdsService.GetChiefAdsBySearch(location, keyword));
            }
            else if (location != null && keyword == null)
            {
                ViewBag.Location = location;
                return View(await _chiefAdsService.GetChiefAdsBySearch(location));
            }
            else
            {
                return View(await _chiefAdsService.GetChiefAds());
            }
        }

        // GET: /usta-ilanlari/detaylar/{*id}
        public async Task<IActionResult> Details(Guid id)
        {
            var advertisement = await _chiefAdsService.GetChiefAdsById(id);
            return View(new ChiefAdsDetailViewModel() { Advertisement = advertisement});
        }

        // GET: /ilanlarim
        public async Task<IActionResult> GetAdvertisementsOfSignedUser()
        {
            var signedUser = await _userManager.GetUserAsync(User);
            return View(await _chiefAdsService.GetAllChiefAdsOfSignedUser(signedUser));
        }

        // GET: ChiefAdsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChiefAdsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ChiefAdvertisement entity)
        {
            if (entity == null)
            {
                return View();
            }
            else
            {
                try
                {
                    //db islemini baska yere tasicaz.
                    var activeUser = await _userManager.GetUserAsync(User);

                    entity.Id = Guid.NewGuid();
                    entity.CreatedAt = DateTime.Now;
                    entity.UserId = activeUser.Id;
                    entity.ApplicationUser = activeUser;
                    entity.AdViewed = 0;

                    await _chiefAdsService.CreateChiefAds(entity);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }

        }

        // GET: ChiefAdsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChiefAdsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChiefAdsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChiefAdsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
