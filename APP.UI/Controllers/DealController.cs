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
        private readonly ApplicationDbContext _dbContext;
        public DealController(IDealService dealService, UserManager<ApplicationUser> userManager, ApplicationDbContext dbContext)
        {
            _dealService = dealService;
            _userManager = userManager;
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> ChiefCompleteDeal(Guid dealId)
        {
            var deal = await _dbContext.Deal.Include(y=>y.OrderOffer).Where(x => x.Id == dealId).FirstOrDefaultAsync();
            if(deal.IsChiefConfirm == false && deal.IsClientConfirm == false)
            {
                deal.IsChiefConfirm = true;
                await _dbContext.SaveChangesAsync();
            }

            return Redirect("/");
        }

        public async Task<IActionResult> ChiefCompletedDealsList()
        {
            return View(await _dealService.ChiefCompletedDeals(await _userManager.GetUserAsync(User)));
        }

        public async Task<IActionResult> ClientCompletedDealsList()
        {
            return View(await _dealService.ClientCompletedDeals(await _userManager.GetUserAsync(User)));
        }

        public async Task<IActionResult> ChiefDeals()
        {
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
            }

            return Redirect("/anasayfa");
        }

        public async Task<IActionResult> ClientDeals()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            return View(await _dealService.ClientDeals(currentUser));
        }

    }
}
