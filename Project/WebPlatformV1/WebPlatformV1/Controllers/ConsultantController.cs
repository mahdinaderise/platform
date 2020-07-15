using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.Controllers
{
    [Authorize(Roles = "Consultant")]

    public class ConsultantController : Controller
    {
        private readonly MainDBContext _context;
        private readonly UserManager<ApplicationUsers> _userManager;

        public ConsultantController(MainDBContext context, UserManager<ApplicationUsers> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index(ConsultantDashboardViewModel model)
        {
           ViewBag.S= _userManager.GetUserId(User);

            return View();
        }
        public IActionResult blog()
        {
            return View();
        }
        public IActionResult paymanagment()
        {
            return View();
        }
    }
}
