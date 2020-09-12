using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.Controllers
{
    public class AdminController : Controller
    {
        private readonly MainDBContext _context;
        private readonly UserManager<ApplicationUsers> _userManager;
        public AdminController(MainDBContext context, UserManager<ApplicationUsers> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var consultant = _context.consultants.Count();
            var ActiveConsultant = _context.consultants.Where(p => p.State == true).Count();
            var DeAcriveConsultant= _context.consultants.Where(p => p.State == false).Count();
            ViewBag.consultant = consultant;
            if (consultant !=0)
            {
                ViewBag.ActiveConsultant = (ActiveConsultant * 100) / consultant;
                ViewBag.DeAcriveConsultant = (DeAcriveConsultant * 100) / consultant;
            }
            var CreditConsultant = _context.tbl_Wallets.Sum(p => p.Credit);
            ViewBag.CreditConsultant = CreditConsultant;
            ViewBag.CountStudent = _context.students.Count();
            var credit= _context.Tbl_Balances.Find(1);
            ViewBag.Credit = credit.SumComosion;
            return View();
        }
        public IActionResult ConsultantManagement()
        {
            var consultants = new List<Consultant>();
            consultants = _context.consultants.Where(p => p.State == false && p.IsSendDegree == true && p.isAcceptDegree == false).ToList();
            return View(consultants);
        }
    }
}
