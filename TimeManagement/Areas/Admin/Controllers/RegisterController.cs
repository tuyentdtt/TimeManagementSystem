using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using TimeManagement.Areas.Admin.Models;
using TimeManagement.Areas.Identity.Pages.Account;
using TimeManagement.Entity;

namespace TimeManagement.Areas.Admin.Controllers
{
    [Area("admin")]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ILogger<RegisterModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        [Route("admin/register")]
        [HttpGet]
        public async Task<IActionResult> Index(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterModel userRegisterModel, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            var name = userRegisterModel.Email;

            if (userRegisterModel.Email == null)
            {
                return NotFound();
            }

            if (userRegisterModel.Password == null)
            {
                return NotFound();
            }

            if (userRegisterModel.ConfirmPassword == null)
            {
                return NotFound();
            }


            var user = new AppUser { UserName = userRegisterModel.Email, Email = userRegisterModel.Email ,EmailConfirmed = true};
            var result = await _userManager.CreateAsync(user, userRegisterModel.Password);
            if (result.Succeeded)
            {
                return Redirect("/admin/userlist");

            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            

            return View();
        }



    }
}
