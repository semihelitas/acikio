using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Core.Models;
using APP.Repository;
using APP.Service.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace APP.UI.Controllers
{
    [Authorize]
    public class OrderOfferController : Controller
    {
        private readonly IOrderOffersService _orderOffersService;
        private readonly IDealService _dealService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _db;
        public OrderOfferController(IOrderOffersService orderOffersService, UserManager<ApplicationUser> userManager, ApplicationDbContext db, IDealService dealService)
        {
            _orderOffersService = orderOffersService;
            _userManager = userManager;
            _db = db;
            _dealService = dealService;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: /yonetim-paneli/tekliflerim
        public async Task<IActionResult> SentOffers()
        {
            return View(await _orderOffersService.GetAllOrderOffersOfUserSent(await _userManager.GetUserAsync(User)));
        }

        // GET: /yonetim-paneli/gelen-teklifler
        public async Task<IActionResult> IncomingOffers()
        {
            return View(await _orderOffersService.GetAllOrderOffersOfUser(await _userManager.GetUserAsync(User)));
        }

        [HttpPost]
        public IActionResult ChiefOfferAcceptance(Guid orderOfferId)
        {
            if (ModelState.IsValid)
            {
                //will refactoring
                var getOrderOffer = _db.OrderOffers.Where(x => x.Id == orderOfferId).FirstOrDefault();
                getOrderOffer.IsChiefAccepted = true;
                _db.SaveChanges();
                return Redirect("/OrderOffer/AcceptanceSuccess");
            }
            return BadRequest();
        }

        public async Task<IActionResult> ClientOrderVerificationAcceptance()
        {
            return View(await _orderOffersService.GetOrderOffersPendingClientResponse(await _userManager.GetUserAsync(User)));
        }

        [HttpPost]
        public async Task<IActionResult> ClientOfferAcceptance(Guid orderOfferId)
        {
            if (ModelState.IsValid)
            {
                //will refactoring
                var getOrderOffer = _db.OrderOffers.Where(x => x.Id == orderOfferId).FirstOrDefault();
                if (getOrderOffer != null)
                {
                    getOrderOffer.IsClientAccepted = true;

                    // Create new deal (refactoring)
                    var deal = new Deal()
                    {
                        Id = Guid.NewGuid(),
                        OrderOffer = getOrderOffer,
                        ChiefId = getOrderOffer.ChiefId,
                        ApplicationUser = getOrderOffer.ApplicationUser,
                        DeliveryTime = getOrderOffer.DeliveryTime,
                        CreatedAt = DateTime.Now,
                        IsCanceled = false,
                        IsChiefConfirm = false,
                        IsClientConfirm = false
                    };

                    await _dealService.CreateDeal(deal);

                    getOrderOffer.IsDeal = true;
                    _db.SaveChanges();

                    return Redirect("/OrderOffer/OrderAgreementSuccessful");
                }
                return BadRequest();
            }
            return BadRequest();
        }

        public IActionResult AcceptanceSuccess()
        {
            return View();
        }

        public IActionResult OrderAgreementSuccessful()
        {
            return View();
        }

        public async Task<IActionResult> OffersOnlyChiefAccepted(ApplicationUser user)
        {
            return View(await _orderOffersService.GetGetOrderOffersOnlyChiefAccepted(await _userManager.GetUserAsync(User)));
        }

        // POST: /yeni-ilan
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrderOffers offer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // refactoring
                    offer.Id = Guid.NewGuid();
                    offer.CreatedAt = DateTime.Now;
                    offer.IsChiefAccepted = false;
                    offer.IsClientAccepted = false;
                    offer.IsDeal = false;
                    await _orderOffersService.CreateOrderOffer(offer);
                    return Redirect("/User/Profile/" + offer.ChiefId);
                }
                catch(Exception)
                {
                    throw;
                }
            }
            else
            {
                return Redirect("/");
            }
        }

        // GET: OrderOfferController/Delete/5
        public async Task RejectOffer(Guid id)
        {
            await _orderOffersService.DeleteOrderOffer(id);
        }
    }
}
