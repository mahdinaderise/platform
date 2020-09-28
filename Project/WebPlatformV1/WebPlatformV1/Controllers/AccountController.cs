using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;
using WebPlatformV1.Repositories;
using WebPlatformV1.ViewModels.Account;
using WebPlatformV1.ViewModels.Admin;

namespace WebPlatformV1.Controllers
{

    public class AccountController : Controller

    {
        private readonly MainDBContext _context;

        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly SignInManager<ApplicationUsers> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMessageSender _messageSender;

        public AccountController(MainDBContext context, UserManager<ApplicationUsers> userManager, SignInManager<ApplicationUsers> signInManager,RoleManager<IdentityRole> roleManager, IMessageSender messageSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;

            _context = context;
            _messageSender = messageSender;

        }
        [HttpGet]
        public IActionResult RegisterConsultant()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RegisterStudent()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RegisterStudent(RegisterViewModel model)
        {
            bool x = await _roleManager.RoleExistsAsync("Student");
            if (!x)
            {
                // first we create Admin rool    
                var role = new IdentityRole();
                role.Name = "Student";
                await _roleManager.CreateAsync(role);
            }

            if (ModelState.IsValid)
            {
                var user = new Student()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    NationalCode = model.NationalCode,
                    State = false,
                    EmailConfirmed = true,
                    Name = model.Name,
                    Family = model.Family
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var result1 = await _userManager.AddToRoleAsync(user, "Student");
                    return RedirectToAction("LoginStudent", "Account");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

            }
            return View(model);

        }
        public IActionResult AccessDenied()
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
                var user = new Consultant()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    NationalCode = model.NationalCode,
                    State = false,
                    EmailConfirmed = true,
                    Name = model.Name,
                    Family = model.Family
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var result1 = await _userManager.AddToRoleAsync(user, "Consultant");

                    return RedirectToAction("LoginConsultant", "Account");
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
        [HttpGet]
        public IActionResult LoginAdmin(string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToAction("Index", "Admin");

            ViewData["returnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginAdmin(LoginViewModel model, string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                //return RedirectToAction("Index", "Consultant");
                return RedirectToAction("Index", "Admin");

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(
                    model.UserName, model.Password, model.RememberMe, true);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);

                    return RedirectToAction("Index", "Admin");
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
        [HttpGet]
        public IActionResult LoginStudent(string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToAction("Index", "Student");

            ViewData["returnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginStudent(LoginViewModel model, string returnUrl = null)
        {
            if (_signInManager.IsSignedIn(User))
                return RedirectToAction("Index", "Student");

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(
                    model.UserName, model.Password, model.RememberMe, true);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        return Redirect(returnUrl);

                    return RedirectToAction("Index", "Student");
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

        public async Task<IActionResult> LogOutStudent()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LoginStudent", "Account");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOutConsultant()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LoginConsultant", "Account");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOutAdmin()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LoginAdmin", "Account");
        }
        //ResetPass
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
               

                ViewData["ErrorMessage"] = "اگر ایمیل وارد معتبر باشد، لینک فراموشی رمزعبور به ایمیل شما ارسال شد";

                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null) return View();

                var resetPasswordToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                var resetPasswordUrl = Url.Action("ResetPassword", "Account",
                    new { email = user.Email, token = resetPasswordToken }, Request.Scheme);

                await _messageSender.SendEmailAsync(user.Email, "لینک تغییر کلمه عبور", resetPasswordUrl);
                return View();
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult ResetPassword(string email, string token)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(token))
                return RedirectToAction("Index", "Home");

            var model = new ResetPasswordViewModel()
            {
                Email = email,
                Token = token
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
               

                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null) return RedirectToAction();
                var result = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
                if (result.Succeeded)
                {
                    ViewData["ErrorMessage"] = "رمزعبور شما با موفقیت تغییر یافت";
                    return View();
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
    }


}
