using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;
using WebPlatformV1.ViewModels.Admin;

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
            var DeAcriveConsultant = _context.consultants.Where(p => p.State == false).Count();
            ViewBag.consultant = consultant;
            if (consultant != 0)
            {
                ViewBag.ActiveConsultant = (ActiveConsultant * 100) / consultant;
                ViewBag.DeAcriveConsultant = (DeAcriveConsultant * 100) / consultant;
            }
            var CreditConsultant = _context.tbl_Wallets.Sum(p => p.Credit);
            ViewBag.CreditConsultant = CreditConsultant;
            ViewBag.CountStudent = _context.students.Count();
            var credit = _context.Tbl_Balances.Find(1);
            ViewBag.Credit = credit.SumComosion;
            return View();
        }
        public IActionResult ConsultantManagement()
        {
            var consultants = new List<Consultant>();
            consultants = _context.consultants.Where(p => p.State == false && p.IsSendDegree == true && p.isAcceptDegree == false).ToList();
            return View(consultants);
        }
        [HttpGet]
        public IActionResult AcceptDeagre(string id, DegreeCheck model)
        {
            var Degree = new List<SendDegree>();
            var consultant = _context.consultants.FirstOrDefault(p => p.Id == id);
            model.Degree = _context.SendDegree.Where(p => p.ConsultantId == id && p.state == 1).ToList();
            ViewBag.Namef = consultant.Name + " " + consultant.Family;
            ViewBag.id = id;
            HttpContext.Session.SetString("Idc", id);

            return View(model);
        }
        [HttpPost]
        public IActionResult AcceptDeagre(int id, DegreeCheck model)
        {
            var idc = HttpContext.Session.GetString("Idc");

            model.Degree = _context.SendDegree.Where(p => p.ConsultantId == idc && p.state == 1).ToList();

            var Degree = _context.SendDegree.Find(id);
            Degree.Id = id;
            Degree.state = 3;
            _context.SendDegree.Update(Degree);
            _context.SaveChanges();
            return View(model);
        }
        [HttpGet]
        public IActionResult RejectDeagre(int id)
        {
            //HttpContext.Session.SetInt32("IdDegree", id);
            ViewBag.id = id;
            return View();
        }
        [HttpPost]
        public IActionResult RejectDeagre(DegreeCheck model)
        {
            if (ModelState.IsValid)
            {
                var Degree = new SendDegree();
                Degree.Id = model.id;
                Degree.Description = model.Description;
                Degree.state = 2;
                _context.SendDegree.Update(Degree);
                _context.SaveChanges();
                return RedirectToAction(nameof(ConsultantManagement));


            }

            //HttpContext.Session.SetInt32("IdDegree", id);
            return View();
        }
        [HttpPost]
        public IActionResult ActiveAccount(string id)
        {
            var consultant = _context.consultants.FirstOrDefault(p => p.Id == id);
            consultant.isAcceptDegree = true;
            _context.consultants.Update(consultant);
            _context.SaveChanges();
            return RedirectToAction(nameof(ConsultantManagement));
        }
    }
}
