using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Core.Models;
using APP.Repository;
using APP.Service.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP.UI.Controllers
{
    public class FoodAdsController : Controller
    {
        private readonly IFoodAdsService _foodAdsService;
        public FoodAdsController(IFoodAdsService foodAdsService)
        {
            _foodAdsService = foodAdsService;
        }

        // GET: FoodAdsController
        public async Task<ActionResult> Index()
        {
            return View(await _foodAdsService.GetFoodAds());
        }

        // GET: FoodAdsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FoodAdsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodAdsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FoodAdvertisement entity)
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

        // GET: FoodAdsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FoodAdsController/Edit/5
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

        // GET: FoodAdsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FoodAdsController/Delete/5
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
