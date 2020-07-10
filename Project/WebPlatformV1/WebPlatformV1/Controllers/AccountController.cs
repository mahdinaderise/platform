using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebPlatformV1.Models;
using WebPlatformV1.ViewModels.Account;

namespace WebPlatformV1.Controllers
{
    public class AccountController : Controller

    {
        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly SignInManager<ApplicationUsers> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<ApplicationUsers> userManager, SignInManager<ApplicationUsers> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult RegisterConsultant()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterConsultant(RegisterViewModel model)

        {
            bool x = await _roleManager.RoleExistsAsync("Consultant");
            if (!x)
            {
                // first we create Admin rool    
                var role = new IdentityRole();
                role.Name = "Consultant";
                await _roleManager.CreateAsync(role);
            }

                if (ModelState.IsValid)
            {
                var user = new ApplicationUsers()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    NationalCode = model.NationalCode,
                   State=true,
                    EmailConfirmed = true
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var result1 = await _userManager.AddToRoleAsync(user, "Consultant");
                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View(model);
        }
        [HttpGet]
        public IActionResult LoginConsultant(string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToAction("Index", "Consultant");

            ViewData["returnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginConsultant(LoginViewModel model, string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                //return RedirectToAction("Index", "Consultant");
                return RedirectToAction("Index", "Consultant");

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(
                    model.UserName, model.Password, model.RememberMe, true);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);

                    return RedirectToAction("Index", "Consultant");
                }

                if (result.IsLockedOut)
                {
                    ViewData["ErrorMessage"] = "اکانت شما به دلیل پنج بار ورود ناموفق به مدت پنج دقیق قفل شده است";
                    return View(model);
                }

                ModelState.AddModelError("", "رمزعبور یا نام کاربری اشتباه است");
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOutConsultant()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LoginConsultant", "Account");
        }
    }

    
}
