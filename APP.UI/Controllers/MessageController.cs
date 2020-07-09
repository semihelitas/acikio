using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APP.Repository;
using Microsoft.AspNetCore.Mvc;
using APP.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using APP.Service.Abstract;
using APP.UI.Models;

namespace APP.UI.Controllers
{
    public class MessageController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IDealService _dealService;
        private readonly UserManager<ApplicationUser> _userManager;
        public MessageController(ApplicationDbContext db, UserManager<ApplicationUser> userManager, IDealService dealService)
        {
            _db = db;
            _dealService = dealService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Inbox(string receiverId)
        {
            var user = await _userManager.GetUserAsync(User);
            var userForChat = new List<ApplicationUser>();
            string role = "";
            var dealWithUsers = new List<Deal>();
            if (await _userManager.IsInRoleAsync(user, "Üye"))
            {
                dealWithUsers = await _db.Deal.Include(x => x.OrderOffer).Where(x => x.OrderOffer.ClientId == user.Id && x.IsDone == false).ToListAsync();
                role = "Üye";
            }
            else
            {
                dealWithUsers = await _db.Deal.Include(x => x.OrderOffer).Where(x => x.OrderOffer.ChiefId == user.Id && x.IsDone == false).ToListAsync();
                role = "Usta";
            }

            foreach (var users in dealWithUsers)
            {
                if (role == "Üye")
                {
                    var getUser = await _db.Users.Where(x => x.Id == users.OrderOffer.ChiefId).FirstOrDefaultAsync();
                    if (!userForChat.Contains(getUser))
                    {
                        userForChat.Add(getUser);
                    }
                }
                else{
                    var getUser = await _db.Users.Where(x => x.Id == users.OrderOffer.ClientId).FirstOrDefaultAsync();
                    if (!userForChat.Contains(getUser))
                    {
                        userForChat.Add(getUser);
                    }
                }
            }

            var newString = receiverId;

            if(receiverId == null)
            {
                var IsThereUser = userForChat.Any();
                if (IsThereUser == true)
                {
                    receiverId = userForChat.FirstOrDefault().Id;
                }
                else
                {
                    return Redirect("/OrderOffer/Dashboard");
                }
            }

            var activeUser = await _userManager.GetUserAsync(User);
            var listOfMessages = new List<Message>();

            var conversationOfSender = await _db.Message.Where(x => x.SenderId == activeUser.Id && x.ReceiverId == receiverId).AsNoTracking().ToListAsync();
            var conversationOfReceiver = await _db.Message.Where(x => x.SenderId == receiverId && x.ReceiverId == activeUser.Id).AsNoTracking().ToListAsync();

            listOfMessages.AddRange(conversationOfSender);
            listOfMessages.AddRange(conversationOfReceiver);

            ViewBag.ChatUsers = userForChat;

            var model = listOfMessages.Where(x => x.ReceiverId == receiverId || x.SenderId == receiverId).OrderBy(x=>x.SentAt).ToList();
            ViewBag.ChatUser = _db.Users.Where(x => x.Id == receiverId).FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        public async Task SendMessage(string receiverId, string messageText)
        {
            var senderUser = await _userManager.GetUserAsync(User);
            var messageEntity = new Message()
            {
                Id = Guid.NewGuid(),
                SenderId = senderUser.Id,
                ReceiverId = receiverId,
                IsItRead = false,
                SentAt = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")),
                MessageText = messageText
            };

            await _db.Message.AddAsync(messageEntity);
            await _db.SaveChangesAsync();
        }
    }
}
