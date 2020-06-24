using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Core.Models;
using APP.Service.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APP.UI.Controllers
{
    [Authorize]
    public class OrderOfferController : Controller
    {
        private readonly IOrderOffersService _orderOffersService;
        public OrderOfferController(IOrderOffersService orderOffersService)
        {
            _orderOffersService = orderOffersService;
        }

        // GET: OrderOfferController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderOfferController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: OrderOfferController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrderOffers offer)
        {
            if (offer != null)
            {
                try
                {
                    offer.Id = Guid.NewGuid();
                    await _orderOffersService.CreateOrderOffer(offer);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        // GET: OrderOfferController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderOfferController/Edit/5
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

        // GET: OrderOfferController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderOfferController/Delete/5
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
