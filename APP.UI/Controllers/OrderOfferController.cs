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
        private readonly INotificationService _notificationService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _db;
        public OrderOfferController(IOrderOffersService orderOffersService, UserManager<ApplicationUser> userManager, ApplicationDbContext db, IDealService dealService, INotificationService notificationService, SignInManager<ApplicationUser> signInManager)
        {
            _orderOffersService = orderOffersService;
            _userManager = userManager;
            _db = db;
            _dealService = dealService;
            _signInManager = signInManager;
            _notificationService = notificationService;

        }

    public async Task<IActionResult> Dashboard()
        {
            var user = await _userManager.GetUserAsync(User);

            var IsUserChef = await _userManager.IsInRoleAsync(user, "Usta");
            var IsUserClient = await _userManager.IsInRoleAsync(user, "Üye");

            if (IsUserChef == true && IsUserClient == false)
            {
                var chiefDeals = await _dealService.ChiefDeals(user);
                ViewBag.ActiveOrders = chiefDeals.Count();

                var incomingOffers = await _orderOffersService.GetAllOrderOffersOfUser(user);
                ViewBag.Offers = incomingOffers.Count();

                var waitingForConfirmation = await _orderOffersService.GetGetOrderOffersOnlyChiefAccepted(user);
                ViewBag.WaitingForConfirmation = waitingForConfirmation.Count();

                var completedOrders = await _dealService.ChiefCompletedDeals(user);
                ViewBag.AllCompletedOrders = completedOrders.OrderByDescending(x => x.CreatedAt).Take(4);
                ViewBag.CompletedOrders = completedOrders.Count();
            }

            if (IsUserClient == true && IsUserChef == false)
            {
                var client = await _dealService.ClientDeals(user);
                ViewBag.ActiveOrders = client.Count();

                var sentOffers = await _orderOffersService.GetAllOrderOffersOfUserSent(user);
                ViewBag.Offers = sentOffers.Count();

                var waitingForConfirmation = await _orderOffersService.GetOrderOffersPendingClientResponse(user);
                ViewBag.WaitingForConfirmation = waitingForConfirmation.Count();

                var completedOrders = await _dealService.ClientCompletedDeals(user);
                ViewBag.AllCompletedOrders = completedOrders.OrderByDescending(x=>x.CreatedAt).Take(4);
                ViewBag.CompletedOrders = completedOrders.Count();
            }

            ViewBag.UserAllNotifications = await _notificationService.GetAllNotifications(user.Id);
            await ShowNotifications();
            return View();
        }

        // GET: /yonetim-paneli/tekliflerim
        public async Task<IActionResult> SentOffers()
        {
            await ShowNotifications();
            return View(await _orderOffersService.GetAllOrderOffersOfUserSent(await _userManager.GetUserAsync(User)));
        }

        // GET: /yonetim-paneli/gelen-teklifler
        public async Task<IActionResult> IncomingOffers()
        {
            await ShowNotifications();
            return View(await _orderOffersService.GetAllOrderOffersOfUser(await _userManager.GetUserAsync(User)));
        }

        [HttpPost]
        public async Task<IActionResult> ChiefOfferAcceptance(Guid orderOfferId)
        {
            if (ModelState.IsValid)
            {
                //will refactoring
                var getOrderOffer = await _db.OrderOffers.Where(x => x.Id == orderOfferId).FirstOrDefaultAsync();
                getOrderOffer.IsChiefAccepted = true;
                _db.SaveChanges();

                var chief = await _userManager.GetUserAsync(User);

                await _notificationService.SendNotification(new Notification()
                {
                    Id = Guid.NewGuid(),
                    SenderId = getOrderOffer.ChiefId,
                    SenderName = "" + chief.Name + " " + chief.Surname,
                    ReceiverId = getOrderOffer.ClientId,
                    IsItRead = false,
                    CreatedAt = DateTime.Now,
                    ReturnUrl = "/OrderOffer/ClientOrderVerificationAcceptance",
                    NotificationString = "siparişinizi kabul etti!"
                });

                return Redirect("/OrderOffer/AcceptanceSuccess");
            }
            return BadRequest();
        }

        public async Task<IActionResult> ClientOrderVerificationAcceptance()
        {
            await ShowNotifications();
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

                    var client = await _userManager.GetUserAsync(User);

                    await _notificationService.SendNotification(new Notification()
                    {
                        Id = Guid.NewGuid(),
                        SenderId = getOrderOffer.ClientId,
                        SenderName = "" + client.Name + " " + client.Surname,
                        ReceiverId = getOrderOffer.ChiefId,
                        IsItRead = false,
                        CreatedAt = DateTime.Now,
                        ReturnUrl = "/Deal/ChiefDeals",
                        NotificationString = "siparişi onayladı! Teslimat süresi geçmeden siparişi hazırlayın."
                    });
                    return Redirect("/OrderOffer/OrderAgreementSuccessful");
                }
                return BadRequest();
            }
            return BadRequest();
        }

        public async Task<IActionResult> AcceptanceSuccessAsync()
        {
            await ShowNotifications();
            return View();
        }

        public async Task<IActionResult> OrderAgreementSuccessfulAsync()
        {
            await ShowNotifications();
            return View();
        }

        public async Task<IActionResult> OffersOnlyChiefAccepted(ApplicationUser user)
        {
            await ShowNotifications();
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

                    var client = await _userManager.GetUserAsync(User);
                    await _notificationService.SendNotification(new Notification()
                    {
                        Id = Guid.NewGuid(),
                        SenderId = offer.ClientId,
                        SenderName = "" + client.Name + " " + client.Surname,
                        ReceiverId = offer.ChiefId,
                        IsItRead = false,
                        CreatedAt = DateTime.Now,
                        ReturnUrl = "/OrderOffer/IncomingOffers",
                        NotificationString = "yeni bir sipariş teklifi gönderdi!"
                    });

                    return Redirect("/User/Profile/" + offer.ChiefId);
                }
                catch (Exception)
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

        public async Task ShowNotifications()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            ViewBag.Notifications = await _notificationService.GetUnreadNotifications(currentUser.Id);
        }
    }
}
