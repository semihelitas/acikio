using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Core.Models;
using APP.Repository;
using APP.Service.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APP.UI.Controllers
{
    public class DealController : Controller
    {
        private readonly IDealService _dealService;
        private UserManager<ApplicationUser> _userManager;
        private readonly INotificationService _notificationService;
        private readonly ApplicationDbContext _dbContext;
        public DealController(IDealService dealService, UserManager<ApplicationUser> userManager, ApplicationDbContext dbContext, INotificationService notificationService)
        {
            _dealService = dealService;
            _userManager = userManager;
            _dbContext = dbContext;
            _notificationService = notificationService;
        }

        public async Task<IActionResult> Invoice(Guid id)
        {
            var completedDeal = await _dealService.GetSingleCompletedDeal(id);
            var completedIncludeDeals = await _dbContext.CompletedDeal.Include(x => x.Deal).ThenInclude(y => y.OrderOffer).ToListAsync();
            var CID = completedIncludeDeals.Where(x => x.Id == id).FirstOrDefault();
            ViewBag.Chef = await _dbContext.Users.Where(x => x.Id == CID.Deal.OrderOffer.ChiefId).FirstOrDefaultAsync();
            ViewBag.Client = await _dbContext.Users.Where(x => x.Id == CID.Deal.OrderOffer.ClientId).FirstOrDefaultAsync();
            return View(completedDeal);
        }

        [HttpPost]
        public async Task<IActionResult> ChiefCompleteDeal(Guid dealId)
        {
            var deal = await _dbContext.Deal.Include(y=>y.OrderOffer).Where(x => x.Id == dealId).FirstOrDefaultAsync();
            if(deal.IsChiefConfirm == false && deal.IsClientConfirm == false)
            {
                deal.IsChiefConfirm = true;
                await _dbContext.SaveChangesAsync();

                var chief = await _userManager.GetUserAsync(User);
                var client = await _dbContext.Users.Where(x => x.Id == deal.OrderOffer.ClientId).FirstOrDefaultAsync();
                await _notificationService.SendNotification(new Notification()
                {
                    Id = Guid.NewGuid(),
                    SenderId = deal.ChiefId,
                    SenderName = "" + chief.Name + " " + chief.Surname,
                    ReceiverId = client.Id,
                    IsItRead = false,
                    CreatedAt = DateTime.Now,
                    ReturnUrl = "/Deal/ClientDeals",
                    NotificationString = "sipariş teslimatını gerçekleştirdi! Bu teslimatı aldıysanız, doğrulamak için onaylayın."
                });
            }

            return Redirect("/");
        }

        public async Task<IActionResult> ChiefCompletedDealsList()
        {
            await ShowNotifications();
            return View(await _dealService.ChiefCompletedDeals(await _userManager.GetUserAsync(User)));
        }

        public async Task<IActionResult> ClientCompletedDealsList()
        {
            await ShowNotifications();
            return View(await _dealService.ClientCompletedDeals(await _userManager.GetUserAsync(User)));
        }

        public async Task<IActionResult> ChiefDeals()
        {
            await ShowNotifications();
            var currentUser = await _userManager.GetUserAsync(User);
            return View(await _dealService.ChiefDeals(currentUser));
        }

        [HttpPost]
        public async Task<IActionResult> ClientCompleteDeal(Guid dealId, string timingScore, string communicationScore, string deliciousScore, string adviceScore, string comment)
        {
            var deal = await _dbContext.Deal.Where(x => x.Id == dealId).Include(y => y.OrderOffer).FirstOrDefaultAsync();
            if (deal.IsChiefConfirm == true && deal.IsClientConfirm == false)
            {
                deal.IsClientConfirm = true;
                deal.IsDone = true;
                _dbContext.SaveChanges();
            }

            if(deal.IsDone == true)
            {
                var completedDeal = new CompletedDeal() {
                    Id = Guid.NewGuid(),
                    Deal = deal,
                    DeliciousScore = Convert.ToDouble(deliciousScore),
                    TimingScore = Convert.ToDouble(timingScore),
                    CommunicationScore = Convert.ToDouble(communicationScore),
                    AdviceScore = Convert.ToDouble(adviceScore),
                    Comment = comment,
                    CreatedAt = DateTime.Now
                };

                await _dealService.CompleteDeal(completedDeal);
                _dbContext.SaveChanges();

                var client = await _userManager.GetUserAsync(User);
                var chief = await _dbContext.Users.Where(x => x.Id == deal.ChiefId).FirstOrDefaultAsync();
                await _notificationService.SendNotification(new Notification()
                {
                    Id = Guid.NewGuid(),
                    SenderId = client.Id,
                    SenderName = "" + client.Name + " " + client.Surname,
                    ReceiverId = chief.Id,
                    IsItRead = false,
                    CreatedAt = DateTime.Now,
                    ReturnUrl = "/Deal/ChiefCompletedDealsList",
                    NotificationString = "sipariş teslimatını onayladı, ellerinize sağlık!"
                });
            }

            return Redirect("/anasayfa");
        }

        public async Task<IActionResult> ClientDeals()
        {
            await ShowNotifications();
            var currentUser = await _userManager.GetUserAsync(User);
            return View(await _dealService.ClientDeals(currentUser));
        }

        public async Task ShowNotifications()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            ViewBag.Notifications = await _notificationService.GetUnreadNotifications(currentUser.Id);
        }
    }
}
