using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using APP.Core.Models;
using APP.Service.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace APP.UI.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly INotificationService _notificationService;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            INotificationService notificationService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _notificationService = notificationService;
        }

        public string Email { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Display(Name = "Adı")]
            public string Name { get; set; }

            [Display(Name = "Soyadı")]
            public string Surname { get; set; }

            [Display(Name = "Konum")]
            public string Location { get; set; }

            [DataType(DataType.PhoneNumber)]
            [Display(Name = "Telefon")]
            public string PhoneNumber { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Doğum Tarihi")]
            public DateTime DateOfBirth { get; set; }

            [Display(Name = "Hakkında")]
            public string AboutMe { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Mevcut Parola")]
            public string CurrentPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Yeni Parola")]
            public string NewPassword { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Yeni Parola Tekrar")]
            public string NewPasswordConfirm { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var currentUser = await _userManager.GetUserAsync(User);

            Email = currentUser.Email;

            Input = new InputModel
            {
                Name = currentUser.Name,
                Surname = currentUser.Surname,
                Location = currentUser.Location,
                PhoneNumber = currentUser.PhoneNumber,
                DateOfBirth = currentUser.DateOfBirth,
                AboutMe = currentUser.AboutMe
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            if (Input.PhoneNumber != null && Input.Name != null && Input.Surname != null && Input.DateOfBirth != null && Input.Location != null && Input.AboutMe != null)
            {
                user.Name = Input.Name;
                user.Surname = Input.Surname;
                user.Location = Input.Location;
                user.DateOfBirth = Input.DateOfBirth;
                user.AboutMe = Input.AboutMe;

                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Beklenmeyen bir hata oluştu!";
                    return RedirectToPage();
                }
            }

            if(Input.CurrentPassword != null && Input.NewPassword != null && Input.NewPasswordConfirm != null)
            {
                if(Input.NewPassword == Input.NewPasswordConfirm)
                {
                    var changePassword = await _userManager.ChangePasswordAsync(user, Input.CurrentPassword, Input.NewPassword);
                    if (!changePassword.Succeeded)
                    {
                        StatusMessage = "Hata! Şifre değiştirelemedi!";
                        return RedirectToPage();
                    }
                }
                else
                {
                    StatusMessage = "Yeni şifreler eşleşmiyor!";
                    return RedirectToPage();
                }
            }
            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Değişiklikler başarıyla kaydedildi!";
            return RedirectToPage();
        }
    }
}
