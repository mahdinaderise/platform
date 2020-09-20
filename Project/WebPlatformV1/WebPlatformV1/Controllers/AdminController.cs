using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;
using WebPlatformV1.ViewModels.Account;
using WebPlatformV1.ViewModels.Admin;
using WebPlatformV1.ViewModels.ConsultantViewModel;

namespace WebPlatformV1.Controllers
{
    public class AdminController : Controller
    {
        private readonly MainDBContext _context;
        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly SignInManager<ApplicationUsers> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AdminController(MainDBContext context, UserManager<ApplicationUsers> userManager, SignInManager<ApplicationUsers> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var consultant = _context.consultants.Count();
            var ActiveConsultant = _context.consultants.Where(p => p.State == true).Count();
            var DeAcriveConsultant = _context.consultants.Where(p => p.State == false).Count();
            ViewBag.consultant = consultant;
            ViewBag.Request = _context.tbl_Requestonlineclasses.Where(p=> p.DisplayForAdmin == true).Count();

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
        public IActionResult ActiveConsultantManagement()
        {
            var consultants = new List<Consultant>();
            consultants = _context.consultants.Where(p => p.State == true && p.IsSendDegree == true && p.isAcceptDegree == true).ToList();
            return View(consultants);
        }
        public IActionResult ProfileOfConsultant(string id,ConsultantProfile model)
        {
            var consultant = _context.consultants.FirstOrDefault(p => p.Id == id);
            ViewBag.Namef = consultant.Name + " " + consultant.Family;
            ViewBag.CountStudent = _context.students.Where(p => p.ConsultantID == id).Count();
            ViewBag.id = id;
            model.HistoryPeys = _context.Tbl_HistoryPeys.Where(p=>p.ConsultantId==id).ToList();
            model.Credit = _context.tbl_Wallets.FirstOrDefault(p => p.ConsultantId == id).Credit;

            return View(model);
        }
        [HttpPost]
        public IActionResult subasWallet(string id, ConsultantProfile model)
        {
            var Wallet = new Tbl_Wallet();
            var consultant = _context.consultants.FirstOrDefault(p => p.Id == id);
           
            Wallet = _context.tbl_Wallets.FirstOrDefault(p => p.ConsultantId == id);
            Wallet.Credit = Wallet.Credit - model.CreditforSub;
            _context.tbl_Wallets.Update(Wallet);
            _context.SaveChanges();
            return RedirectToAction(nameof(ActiveConsultantManagement));
        }
        [HttpPost]
        public IActionResult AddToWallet(string id, ConsultantProfile model)
        {
            var Wallet = new Tbl_Wallet();
            var consultant = _context.consultants.FirstOrDefault(p => p.Id == id);

            Wallet = _context.tbl_Wallets.FirstOrDefault(p => p.ConsultantId == id);
            Wallet.Credit = Wallet.Credit + model.Creditforadd;
            _context.tbl_Wallets.Update(Wallet);
            _context.SaveChanges();
            return RedirectToAction(nameof(ActiveConsultantManagement));
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
        [HttpGet]
        public IActionResult RequestPeymentList(RequestListPey model)
        {
            model.Request = _context.Tbl_RequestPeyment.Where(p => p.IsStatus == true && p.IsPey == false).Include(c=>c.consultants).ToList();

            return View(model);
        }
        [HttpGet]
        public IActionResult consultantPageForPey(int id , RequestListPey model)
        {
            model.SRequest = _context.Tbl_RequestPeyment.FirstOrDefault(p=>p.id==id);
            var consultant = _context.consultants.FirstOrDefault(p => p.Id == model.SRequest.ConsultantID);
            ViewBag.NameF = consultant.Name + " " + consultant.Family;
            ViewBag.CountRequest = _context.Tbl_RequestPeyment.Where(p => p.ConsultantID == model.SRequest.ConsultantID).Count();
            ViewBag.Creditc = _context.tbl_Wallets.FirstOrDefault(p => p.ConsultantId == model.SRequest.ConsultantID).Credit;
            return View(model);
        }
        [HttpPost]
        public IActionResult consultantPageForPey(int id, RequestListPey model, Tbl_RequestPeyment req)
        {
            
            model.SRequest = _context.Tbl_RequestPeyment.FirstOrDefault(p => p.id == id);
            var consultant = _context.consultants.FirstOrDefault(p => p.Id == model.SRequest.ConsultantID);
            ViewBag.NameF = consultant.Name + " " + consultant.Family;
            ViewBag.CountRequest = _context.Tbl_RequestPeyment.Where(p => p.ConsultantID == model.SRequest.ConsultantID).Count();
            ViewBag.Creditc = _context.tbl_Wallets.FirstOrDefault(p => p.ConsultantId == model.SRequest.ConsultantID).Credit;
            var Wallet = _context.tbl_Wallets.FirstOrDefault(p => p.ConsultantId == model.SRequest.ConsultantID);
            if (Wallet.Credit>= model.SRequest.value)
            {
                Wallet.Credit = Wallet.Credit - model.SRequest.value;
                req.id = id;
                req.IsPey = true;
                req.IsStatus = false;
                req.Descrontion = "درخواست شما بررسی و مبلغ درخواستی از کیف پول شما به حساب شما واریز شد ";
                req.refid = model.refid;
                _context.Tbl_RequestPeyment.Update(req);
                _context.tbl_Wallets.Update(Wallet);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.Error = "مقدار درخواستی بیشتر از میزان اعتبار است";
            }
          
            return View(model);
        }
        public IActionResult RejectPeyRequest(int id, RequestListPey model, Tbl_RequestPeyment req)
        {
            req.id = id;
            req.IsPey = false;
            req.IsStatus = false;
            req.Descrontion = model.Descrontion;
            _context.Tbl_RequestPeyment.Update(req);
            _context.SaveChanges();
            return View();
        }
        public IActionResult ComisionManagement(Tbl_Comision model)
        {
            model.percent = _context.Tbl_Comisions.Find(1).percent;
            model.price = _context.Tbl_Comisions.Find(2).price;
            return View(model);
        }
        public IActionResult AcriveRequestClassAdmin(RequestListClass model)
        {
            model.Request = _context.tbl_Requestonlineclasses.Where(p=>p.DisplayForAdmin==true).ToList();

            return View(model);
        }
        public IActionResult ReplayRequest(int id,RequestListClass model)
        {
            model.SRequest = _context.tbl_Requestonlineclasses.FirstOrDefault(p => p.DisplayForAdmin == true && p.id==id);
            var studentName = _context.students.FirstOrDefault(p => p.Id == model.SRequest.StudentID).Name;
            var studentFamily = _context.students.FirstOrDefault(p => p.Id == model.SRequest.StudentID).Family;
            ViewBag.NameF = studentName + " " + studentFamily;
            var ConsultantName = _context.consultants.FirstOrDefault(p => p.Id == model.SRequest.ConsultantID).Name;
            var ConsultantFamily = _context.consultants.FirstOrDefault(p => p.Id == model.SRequest.ConsultantID).Family;
            ViewBag.NameFM = ConsultantName + " " + ConsultantFamily;
            return View(model);
        }
        [HttpPost]
        public IActionResult ReplayRequest(int id)
        {
            //var model = new RequestListClass(); 
            //model.SRequest = _context.tbl_Requestonlineclasses.FirstOrDefault(p => p.DisplayForAdmin == true && p.id == id);
            //var studentName = _context.students.FirstOrDefault(p => p.Id == model.SRequest.StudentID).Name;
            //var studentFamily = _context.students.FirstOrDefault(p => p.Id == model.SRequest.StudentID).Family;
            //ViewBag.NameF = studentName + " " + studentFamily;
            //var ConsultantName = _context.consultants.FirstOrDefault(p => p.Id == model.SRequest.ConsultantID).Name;
            //var ConsultantFamily = _context.consultants.FirstOrDefault(p => p.Id == model.SRequest.ConsultantID).Family;
            //ViewBag.NameFM = ConsultantName + " " + ConsultantFamily;


            var req= _context.tbl_Requestonlineclasses.FirstOrDefault(p => p.id == id);
            req.statusForAdmin = true;
            req.DisplayForAdmin = false;
            req.id = id;
            _context.tbl_Requestonlineclasses.Update(req);
            _context.SaveChanges();
            return RedirectToAction(nameof(AcriveRequestClassAdmin));
        }
        [HttpGet]
        public IActionResult Registeradmin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registeradmin(RegisterViewModel model)
        {
            bool x = await _roleManager.RoleExistsAsync("Admin");
            if (!x)
            {
                // first we create Admin rool    
                var role = new IdentityRole();
                role.Name = "Admin";
                await _roleManager.CreateAsync(role);
            }

            if (ModelState.IsValid)
            {
                var user = new ApplicationUsers()
                {
                    UserName = model.UserName,
                    Email = model.Email,
                  
                    EmailConfirmed = true,
               
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var result1 = await _userManager.AddToRoleAsync(user, "Admin");
                    return RedirectToAction("Index", "admin");
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
