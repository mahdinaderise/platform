using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;
using WebPlatformV1.ViewModels.Admin;
using WebPlatformV1.ViewModels.Consultant;
using WebPlatformV1.ViewModels.ConsultantViewModel;
using ZarinpalSandbox;

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

        //public IActionResult Index(ConsultantDashboardViewModel model)
        //{
        //   ViewBag.S= _userManager.GetUserId(User);

        //    return View();
        //}
        public IActionResult Index(todoappc model)
        {
            var cId = _userManager.GetUserId(User);
            ViewBag.Request = _context.tbl_Requestonlineclasses.Where(p => p.ConsultantID == cId && p.statusForConsultant == false).Count();
            var w = _context.tbl_Wallets.Where(p => p.ConsultantId == cId).ToList();
            if (w.Count == 0)
            {
                var Wallet = new Tbl_Wallet();
                Wallet.ConsultantId = cId;
                Wallet.Credit = 0;
               
                _context.tbl_Wallets.Add(Wallet);
                _context.SaveChanges();
                //var consul = new Consultant();
                //consul.Id = cId;
                //consul.WalletId = Wallet.ID;
            }
            var tasks = _context.tbl_Tasks.Where(p => p.ConsultantId == cId).Count();
            var tasksdo = _context.tbl_Tasks.Where(p => p.ConsultantId == cId && p.isDo == true).Count();
            var tasksNdo = _context.tbl_Tasks.Where(p => p.ConsultantId == cId && p.isDo == false).Count();
            var todayTask = _context.tbl_Tasks.Where(p => p.SendDelivery == DateTime.Today).Count();
            ViewBag.CountStudent = _context.students.Where(p => p.ConsultantID == cId).Count();
            var c= _context.tbl_Wallets.Where(p => p.ConsultantId == cId).ToList();
            foreach (var item in c)
            {
                ViewBag.Credit = item.Credit;

            }
            if (tasks != 0)
            {
                ViewBag.DoTest = (tasksdo * 100) / tasks;
                ViewBag.NDoTest = (tasksNdo * 100) / tasks;
            }
           
            ViewBag.Tasks = tasks;
            ViewBag.tasksdo = tasksdo;
            ViewBag.today = todayTask;
            model.Todo = _context.Tbl_TodoAppConsultant.Where(p => p.ConsultantID == cId).ToList();
            //var result = _context.studentOfCansultants.Where(p => p.Cansultant.Equals(_userManager.GetUserId(User)));

            return View(model);
        }

        public IActionResult StudentPage(string id, TasksStudents model)
        {

            model.Students = _context.students.Where(p => p.Id == id).ToList();
            TempData["mydata"] = id;
            HttpContext.Session.SetString("id", id);

            var NowDateTime = DateTime.Today;
            var StartDate = model.StartDate;
            var EndDate = model.EndDate;
            var r = _context.students.Find(id);

            model.tasks = _context.tbl_Tasks.Where(p => p.StudentId == id && p.SendDelivery == DateTime.Today).ToList();
            ViewBag.tasksdo = _context.tbl_Tasks.Where(p => p.StudentId == id && p.isDo == true).Count();
            var credittime = r.CreditTime.DayOfYear;
            var Today = DateTime.Today.DayOfYear;
            if (credittime - Today > 0)
            {
                ViewBag.credittime = credittime - Today;

            }
            else
            {
                ViewBag.credittime = 0;
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentPage(TasksStudents model)
        {
            var id = HttpContext.Session.GetString("id");
            model.Students = _context.students.Where(p => p.Id == id).ToList();
            model.tasks = _context.tbl_Tasks.Where(p => p.StudentId == id && p.SendDelivery == model.StartDate).ToList();
           

            return View(model);
        }

        public IActionResult detaildo(int id, detaildo model)
        {
            var result = _context.Find<Tbl_Do>(id);
            model.DiscriptiveTime = result.DiscriptiveTime;
            model.falseTest = result.falseTest;
            model.TrueTest = result.TrueTest;
            model.NullTest = result.NullTest;
            model.RevisionTime = result.RevisionTime;
            model.TestTime = result.TestTime;
            return View(model);
        }
        //[HttpPost]
        //public IActionResult StudentPage(string id, TasksStudent model)
        //{
        //    model.Students = _context.students.Where(p => p.Id == id).ToList();
        //    var NowDateTime = DateTime.Today;

        //    model.tasks = _context.tbl_Tasks.Where(p => p.Student.Id == id && p.SendDelivery == NowDateTime).ToList();
        //    return View(model);
        //}
        [HttpGet]
        public IActionResult blog(Blog model)
        {
            var consultantId = _userManager.GetUserId(User);
            var result = _context.consultants.Find(consultantId);
            model.blog = _context.tbl_Blogs.Where(p => p.ConsultantId == consultantId).OrderByDescending(P => P.ID).ToList();
            model.Name = result.Name;
            model.Family = result.Family;
            model.Email = result.Email;
            model.id = result.Id;
            string FristLast = result.Family;
            string fristCharecter = result.Name;
            ViewBag.fristCharecter = fristCharecter[0] + " " + FristLast[0].ToString();
            model.ProfilePicUrl = result.ProfilePicUrl;
            model.CountPost = _context.tbl_Blogs.Where(p => p.ConsultantId == consultantId).Count();
            model.CountStudent = _context.students.Where(p => p.ConsultantID == consultantId).Count();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> blog(Tbl_Blog blogs, Blog model)
        {
            var consultantId = _userManager.GetUserId(User);
            if (ModelState.IsValid)
            {
                blogs.Note = model.Note;

                blogs.ConsultantId = consultantId;
                await _context.AddAsync(blogs);
                await _context.SaveChangesAsync();
                if (model.Picture?.Length > 0)
                {
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "images",

                        blogs.ID + Path.GetExtension(model.Picture.FileName));
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Picture.CopyTo(stream);
                    }
                }
                return RedirectToAction(nameof(blog));
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> EditPost(int? id, Tbl_Blog model)
        {
            if (id == null)
            {
                return NotFound();
            }

            model = _context.Find<Tbl_Blog>(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(int id, [Bind("ID", "Note")] Tbl_Blog model)
        {
            var consultantId = _userManager.GetUserId(User);


            if (id != model.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                model.ConsultantId = consultantId;

                _context.Update(model);
                await _context.SaveChangesAsync();


                return RedirectToAction(nameof(blog));
            }
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Post = await _context.tbl_Blogs
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Post == null)
            {
                return NotFound();
            }

            return View(Post);
        }
        [HttpPost, ActionName("DeletePost")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Post = await _context.tbl_Blogs.FindAsync(id);
            _context.tbl_Blogs.Remove(Post);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(blog));
        }
        [HttpGet]
        public IActionResult CreateTask(CreateTask model, Tbl_Tasks tasks, Tbl_grade grade)
        {
            var NowDateTime = DateTime.Today;
            var id = HttpContext.Session.GetString("id");
            ViewData["course"] = new SelectList(_context.tbl_Courses, "IDCourse", "NameCourse", tasks.StudentId);
            ViewData["Grade"] = new SelectList(_context.grades, "IDGrade", "grade", grade.IDGrade);

            model.tasks = _context.tbl_Tasks.Where(p => p.StudentId == id && p.SubmitDate == NowDateTime).ToList();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTask(CreateTask model, Tbl_Tasks tasks, string? name)
        {
            var id = HttpContext.Session.GetString("id");

            if (ModelState.IsValid)
            {
                tasks.Descibtion = model.Descibtion;
                tasks.NameTasks = model.NameTasks;
                tasks.Subject = model.Subject;
                tasks.ConsultantId = _userManager.GetUserId(User);
                tasks.StudentId = id;
                tasks.CourseIDCourse = model.courseid;
                tasks.SendDelivery = model.SendDelivery;
                tasks.SubmitDate = DateTime.Today;
                await _context.AddAsync(tasks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(CreateTask));
            }
            return View(model);
        }

        public IActionResult paymanagment()
        {
            return View();
        }
        public IActionResult students(StudentsViewModel model)
        {
            var consultantId = _userManager.GetUserId(User);
            model.Students = _context.students.Where(p => p.ConsultantID == consultantId).ToList();

            return View(model);
        }
        [HttpGet]
        public IActionResult AddPanel(string id)
        {
            HttpContext.Session.SetString("IdStudentForPanel", id);
            var r = _context.tbl_AddPanels.Where(p => p.StudentID == id).Count();
            if (r != 0)
            {
                return RedirectToAction(nameof(haspanel));

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPanel(Panel model, Tbl_AddPanel addPanel)
        {
            var id = HttpContext.Session.GetString("IdStudentForPanel");
            if (ModelState.IsValid)
            {
                addPanel.ConsultantID = _userManager.GetUserId(User);
                addPanel.Day = model.Day;
                addPanel.Price = model.price;
                addPanel.StudentID = id;
                await _context.tbl_AddPanels.AddAsync(addPanel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(students));

            }

            return View();
        }
        [HttpGet]
        public IActionResult AddNewPanel(string id)
        {
            HttpContext.Session.SetString("IdStudentForNewPanel", id);

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNewPanel(Panel model, Tbl_AddPanel addPanel)
        {
            var id = HttpContext.Session.GetString("IdStudentForNewPanel");
            if (ModelState.IsValid)
            {
                addPanel.ConsultantID = _userManager.GetUserId(User);
                addPanel.Day = model.Day;
                addPanel.Price = model.price;
                addPanel.StudentID = id;
                await _context.tbl_AddPanels.AddAsync(addPanel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(students));

            }

            return View();
        }
        [HttpGet]
        public IActionResult haspanel()
        {
            ViewBag.idstudent = HttpContext.Session.GetString("IdStudentForPanel");

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> haspanel(string id)
        {
            id = HttpContext.Session.GetString("IdStudentForPanel");
            var panel = _context.tbl_AddPanels.Where(p => p.StudentID == id);

            //_context.tbl_AddPanels.Remove(panel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AddPanel));

            return View();
        }
        [HttpGet]
        public IActionResult Profile(Profile model)
        {

            var consultantId = _userManager.GetUserId(User);

            var C = _context.Find<Consultant>(consultantId);
            //var user = _context.consultants.Select(p=>p.Name  p.Family , p.PhoneNumber).Where(p => p.Id == consultantId).ToList();
            model.Degree = _context.SendDegree.Where(p => p.ConsultantId == consultantId).ToList();
            #region view data in textbox


            model.id = C.Id;
            model.Name = C.Name;
            model.Family = C.Family;
            model.Address = C.Address;
            model.CardNumber = C.CardNumber;
            model.PhoneNumber = C.PhoneNumber;
            model.Shaba = C.Shaba;
            model.ProfilePicUrl = C.ProfilePicUrl;
            model.telephone = C.telephone;
            model.Province = C.Province;
            model.city = C.city;
            #endregion

            #region get on char of name and family

            //model.Consultants = _context.consultants.Where(p => p.Id == user).ToList();
            //consultants = _context.consultants.Where(p=>p.Id==id).ToList();
            if (model.Name != null && model.Family != null)
            {
                string FristLast = model.Family;
                string fristCharecter = model.Name;
                ViewBag.fristCharecter = fristCharecter[0] + " " + FristLast[0].ToString();
            }


            #endregion

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(Profile model, Consultant consultant)
        {
            var consultantId = _userManager.GetUserId(User);
            var c = _context.consultants.FirstOrDefault(p => p.Id == consultantId);
            if (c != null)
            {
                c.Name = model.Name;
                c.Family = model.Family;
                c.Address = model.Address;
                c.CardNumber = model.CardNumber;
                c.PhoneNumber = model.PhoneNumber;
                c.Shaba = model.Shaba;
                c.city = model.city;
                c.Province = model.Province;
                c.telephone = model.telephone;
                await _context.SaveChangesAsync();
                if (model.Picture?.Length > 0)
                {
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "images", "Profile",

                        c.Id + Path.GetExtension(model.Picture.FileName));
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Picture.CopyTo(stream);
                        var test = filePath;
                        c.ProfilePicUrl = filePath;
                        await _context.SaveChangesAsync();

                        consultant.ProfilePicUrl = model.Picture.ToString();
                    }
                }

                return RedirectToAction(nameof(Profile));

            }


            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ProfileDegree(Profile model)
        {
            var consultantId = _userManager.GetUserId(User);
            if (model != null)
            {
               
         
                if (model.DegreePic?.Length > 0)
                {
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "images", "Degree",

                        consultantId + Path.GetExtension(model.DegreePic.FileName));
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.DegreePic.CopyTo(stream);
                        SendDegree sendDegree = new SendDegree();
                        sendDegree.IsSend = true;
                        sendDegree.ConsultantId = consultantId;
                        sendDegree.state = 1;
                        sendDegree.type = "Degree";
                        _context.SendDegree.Add(sendDegree);
                        _context.SaveChanges();

                    }
                }
                if (model.DegreemeliPic?.Length > 0)
                {
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "images", "Degree",

                        consultantId+"m" + Path.GetExtension(model.DegreemeliPic.FileName));
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.DegreemeliPic.CopyTo(stream);
                        SendDegree sendDegreemeli = new SendDegree();
                        sendDegreemeli.IsSend = true;
                        sendDegreemeli.ConsultantId = consultantId;
                        sendDegreemeli.state = 1;
                        sendDegreemeli.type = "Melli";
                        var con = _context.consultants.Find(consultantId);
                        con.IsSendDegree = true;
                        _context.SendDegree.Add(sendDegreemeli);
                        _context.SaveChanges();

                    }
                }
                return RedirectToAction(nameof(Profile));

            }


            return View(model);
        }
        public IActionResult Tasks(StudentsViewModel model)
        {
            var consultantId = _userManager.GetUserId(User);
            model.Students = _context.students.Where(p => p.ConsultantID == consultantId).ToList();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> TodoApp(todoappc model, Tbl_TodoAppConsultant todo)
        {
            var studentId = _userManager.GetUserId(User);
            todo.Note = model.Note;
            todo.ConsultantID = model.consultantid;
            todo.IsFinally = model.IsFinally;

            await _context.Tbl_TodoAppConsultant.AddAsync(todo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> TodoAppupdate(todoappc model, Tbl_TodoAppConsultant todo)
        {
            var studentId = _userManager.GetUserId(User);
            todo.Note = model.Note;
            todo.ConsultantID = model.consultantid;
            todo.IsFinally = model.IsFinally;
            todo.Id = model.id;
            await _context.Tbl_TodoAppConsultant.AddAsync(todo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //public IActionResult PanelConsultant(consultantpanel model)
        //{
        //    model.Panel = _context.PanelConsultant.ToList();
        //    return View(model);
        //}
        [HttpGet]
        public IActionResult AddToWallet()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddToWallet(AddToWallet model)
        {
            HttpContext.Session.SetInt32("Price", model.Price);

            return RedirectToAction(nameof(Peyment));
        }
        public IActionResult Peyment()
        {
          var  price = HttpContext.Session.GetInt32("Price");

            var payment = new Payment((int)price);
            var res = payment.PaymentRequest($"پرداخت فاکتور",
               "http://localhost:5000/Consultant/OnlinePayment/", "Mahdinaderi.se@outlook.com", "09130087194");

            if (res.Result.Status == 100)
            {

                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }
            else
            {
                return BadRequest();
            }
            return View();
        }
        public IActionResult OnlinePayment()
        {
            var cid = _userManager.GetUserId(User);

            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok" &&
                HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"].ToString();
                var price = HttpContext.Session.GetInt32("Price");

                var consultant = _context.consultants.FirstOrDefault(p => p.Id == cid);
                var Wallet = _context.tbl_Wallets.FirstOrDefault(p => p.ConsultantId == cid);
                var payment = new Payment((int)price);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    Wallet.Credit = Wallet.Credit+(int)price;
                    Tbl_Finnial savepeyhistory = new Tbl_Finnial();
                    savepeyhistory.DatePey = DateTime.Today;
                    savepeyhistory.IDConsultant = cid;
                    savepeyhistory.NumReceipt = res.RefId;
                    savepeyhistory.State = true;
                    _context.Tbl_Finnials.Add(savepeyhistory);
                    _context.tbl_Wallets.Update(Wallet);

                    _context.consultants.Update(consultant);

                    _context.SaveChanges();
                    ViewBag.code = res.RefId;
                    return View();
                }
            }

            return NotFound();
        }
        public IActionResult MyRequestList(RequestListPey model)
        {
            var cid = _userManager.GetUserId(User);

            model.Request = _context.Tbl_RequestPeyment.Where(p => p.ConsultantID == cid).ToList();
            return View(model);
        }
      
        public IActionResult SendRequest(RequestListPey model)
        {
            var cid = _userManager.GetUserId(User);

            var consultant = _context.consultants.FirstOrDefault(p=>p.Id==cid);
            ViewBag.CardNumber = consultant.CardNumber;
            ViewBag.Shaba = consultant.Shaba;
            return View(model);
        }
        [HttpPost]
        public IActionResult SendRequest(RequestListPey model,int?id)
        {
            var cid = _userManager.GetUserId(User);
            var req = new Tbl_RequestPeyment();
            if (ModelState.IsValid)
            {
                req.CardNumber = model.CardNumber;
                req.ConsultantID = cid;
                req.Shaba = model.Shaba;
                req.value = model.values1;
                req.IsStatus = true;
                _context.Tbl_RequestPeyment.Add(req);
                _context.SaveChanges();
                return RedirectToAction(nameof(MyRequestList));

            }

            return View(model);
        }
        public IActionResult AcriveRequestClass(RequestListClass model)
        {
            var cid = _userManager.GetUserId(User);

            model.Request = _context.tbl_Requestonlineclasses.Where(p => p.statusForConsultant == false && p.ConsultantID == cid).ToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult ReplayRequestForAdmin(int id, RequestListClass model)
        {
            var cid = _userManager.GetUserId(User);

            model.SRequest = _context.tbl_Requestonlineclasses.FirstOrDefault(p => p.statusForConsultant == false && p.ConsultantID == cid &&p.id==id);
            var student = _context.students.FirstOrDefault(p=>p.Id==model.SRequest.StudentID);
            ViewBag.NameF = student.Name + " " + student.Family;
            return View(model);
        }
        [HttpPost]
        public IActionResult ReplayRequestForAdmin(int id, RequestListClass model,Tbl_RequestonlineclassStudent Req)
        {
            var cid = _userManager.GetUserId(User);
            model.SRequest = _context.tbl_Requestonlineclasses.FirstOrDefault(p => p.statusForConsultant == false && p.ConsultantID == cid && p.id == id);

            var student = _context.students.FirstOrDefault(p => p.Id == model.SRequest.StudentID);
            ViewBag.NameF = student.Name + " " + student.Family;
            var Wallet = _context.tbl_Wallets.FirstOrDefault(p => p.ConsultantId == cid);
            var Comision = _context.Tbl_Comisions.FirstOrDefault(p => p.Id == 3);
            var Balance = _context.Tbl_Balances.Find(1);
            if (Wallet.Credit>=Comision.price)
            {
                Balance.SumComosion = Balance.SumComosion + Comision.price;
                Wallet.ID = Wallet.ID;
              Wallet.Credit=  Wallet.Credit - Comision.price;
                Req.id = id;
                Req.statusForConsultant = true;
                Req.RequestTextConsultant = model.SRequest.RequestTextConsultant;
                Req.DisplayForAdmin = true;
                _context.Tbl_Balances.Update(Balance);
                _context.tbl_Wallets.Update(Wallet);
                _context.tbl_Requestonlineclasses.Update(Req);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.ErrorCredit = "کیف پول شما به مقدار کافی اعتبار ندارد.";
                ViewBag.Amount = Comision.price;
            }
           
            return View(model);
        }
        public IActionResult Report(string id)
        {
            if (id == null)
            {
                RedirectToAction(nameof(Tasks));
            }
            var cid = _userManager.GetUserId(User);
            var day = DateTime.Today;
            var dayint = day.AddDays(-30);

            #region get Report from Math
            var Math = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 1 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyMath = 0;
            var StimeStudyMath = 0;
            var SMTrueTest = 0;
            var SMFalseTest = 0;
            var SMNullTest = 0;
            foreach (var item in Math)
            {
                timestudyMath = item.TimeStudy + timestudyMath;
                StimeStudyMath = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyMath;
                SMTrueTest = SMTrueTest + item.Do.TrueTest;
                SMFalseTest = SMFalseTest + item.Do.falseTest;
                SMNullTest = SMNullTest + item.Do.NullTest;
                ViewBag.timestudyMath = timestudyMath;
                ViewBag.StimeStudyMath = StimeStudyMath;
                ViewBag.SMTrueTest = SMTrueTest;
                ViewBag.SMFalseTest = SMFalseTest;
                ViewBag.SMNullTest = SMNullTest;
            }
            #endregion
            #region get Report from adab
            var adab = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 3 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyadab = 0;
            var StimeStudyadab = 0;
            var SATrueTest = 0;
            var SAFalseTest = 0;
            var SANullTest = 0;
            foreach (var item in adab)
            {
                timestudyadab = item.TimeStudy + timestudyadab;
                StimeStudyadab = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyadab;
                ViewBag.timestudyadab = timestudyadab;
                ViewBag.StimeStudyadab = StimeStudyadab;
                SATrueTest = SATrueTest + item.Do.TrueTest;
                SAFalseTest = SAFalseTest + item.Do.falseTest;
                SANullTest = SANullTest + item.Do.NullTest;
                ViewBag.SATrueTest = SATrueTest;
                ViewBag.SAFalseTest = SAFalseTest;
                ViewBag.SANullTest = SANullTest;
            }

            #endregion
            #region  get Report from zabanfarsi
            var zabanfarsi = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 4 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyzabanfarsi = 0;
            var StimeStudyzabanfarsi = 0;
            var SZTrueTest = 0;
            var SZFalseTest = 0;
            var SZNullTest = 0;
            foreach (var item in zabanfarsi)
            {
                timestudyzabanfarsi = item.TimeStudy + timestudyzabanfarsi;
                StimeStudyzabanfarsi = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyzabanfarsi;
                ViewBag.timestudyzabanfarsi = timestudyzabanfarsi;
                ViewBag.StimeStudyzabanfarsi = StimeStudyzabanfarsi;
                SZTrueTest = SZTrueTest + item.Do.TrueTest;
                SZFalseTest = SZFalseTest + item.Do.falseTest;
                SZNullTest = SZNullTest + item.Do.NullTest;
                ViewBag.SZTrueTest = SZTrueTest;
                ViewBag.SZFalseTest = SZFalseTest;
                ViewBag.SZNullTest = SZNullTest;
            }
            #endregion
            #region get Report from arabi
            var arabi = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 5 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyarabi = 0;
            var StimeStudyarabi = 0;
            var SaTrueTest = 0;
            var SaFalseTest = 0;
            var SaNullTest = 0;
            foreach (var item in arabi)
            {
                timestudyarabi = item.TimeStudy + timestudyarabi;
                StimeStudyarabi = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyarabi;
                ViewBag.timestudyarabi = timestudyarabi;
                ViewBag.StimeStudyarabi = StimeStudyarabi;
                SaTrueTest = SaTrueTest + item.Do.TrueTest;
                SaFalseTest = SaFalseTest + item.Do.falseTest;
                SaNullTest = SaNullTest + item.Do.NullTest;
                ViewBag.SaTrueTest = SaTrueTest;
                ViewBag.SaFalseTest = SaFalseTest;
                ViewBag.SaNullTest = SaNullTest;
            }
            #endregion
            #region  get Report from dinzendegi
            var dinzendegi = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 6 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudydinzendegi = 0;
            var StimeStudydinzendegi = 0;
            var SdTrueTest = 0;
            var SdFalseTest = 0;
            var SdNullTest = 0;
            foreach (var item in dinzendegi)
            {
                timestudydinzendegi = item.TimeStudy + timestudydinzendegi;
                StimeStudydinzendegi = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudydinzendegi;
                ViewBag.timestudydinzendegi = timestudydinzendegi;
                ViewBag.StimeStudydinzendegi = StimeStudydinzendegi;
                SdTrueTest = SdTrueTest + item.Do.TrueTest;
                SdFalseTest = SdFalseTest + item.Do.falseTest;
                SdNullTest = SdNullTest + item.Do.NullTest;
                ViewBag.SdTrueTest = SdTrueTest;
                ViewBag.SdFalseTest = SdFalseTest;
                ViewBag.SdNullTest = SdNullTest;
            }
            #endregion
            #region  get Report from english
            var english = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 7 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyenglish = 0;
            var StimeStudyenglish = 0;
            var SeTrueTest = 0;
            var SeFalseTest = 0;
            var SeNullTest = 0;
            foreach (var item in english)
            {
                timestudyenglish = item.TimeStudy + timestudyenglish;
                StimeStudyenglish = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyenglish;
                ViewBag.timestudyenglish = timestudyenglish;
                ViewBag.StimeStudyenglish = StimeStudyenglish;
                SeTrueTest = SeTrueTest + item.Do.TrueTest;
                SeFalseTest = SeFalseTest + item.Do.falseTest;
                SeNullTest = SeNullTest + item.Do.NullTest;
                ViewBag.SeTrueTest = SeTrueTest;
                ViewBag.SeFalseTest = SeFalseTest;
                ViewBag.SeNullTest = SeNullTest;
            }
            #endregion
            #region  get Report from zamin
            var zamin = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 8 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyzamin = 0;
            var StimeStudyzamin = 0;
            var SzTrueTest = 0;
            var SzFalseTest = 0;
            var SzNullTest = 0;
            foreach (var item in zamin)
            {
                timestudyzamin = item.TimeStudy + timestudyzamin;
                StimeStudyzamin = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyzamin;
                ViewBag.timestudyzamin = timestudyzamin;
                ViewBag.StimeStudyzamin = StimeStudyzamin;
                SzTrueTest = SzTrueTest + item.Do.TrueTest;
                SzFalseTest = SzFalseTest + item.Do.falseTest;
                SzNullTest = SzNullTest + item.Do.NullTest;
                ViewBag.SzTrueTest = SzTrueTest;
                ViewBag.SzFalseTest = SzFalseTest;
                ViewBag.SzNullTest = SzNullTest;
            }
            #endregion
            #region  get Report from zist
            var zist = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 9 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyzist = 0;
            var StimeStudyzist = 0;
            var SziTrueTest = 0;
            var SziFalseTest = 0;
            var SziNullTest = 0;
            foreach (var item in zist)
            {
                timestudyzist = item.TimeStudy + timestudyzist;
                StimeStudyzist = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyzist;
                ViewBag.timestudyzist = timestudyzist;
                ViewBag.StimeStudyzist = StimeStudyzist;
                SziTrueTest = SziTrueTest + item.Do.TrueTest;
                SziFalseTest = SziFalseTest + item.Do.falseTest;
                SziNullTest = SziNullTest + item.Do.NullTest;
                ViewBag.SziTrueTest = SziTrueTest;
                ViewBag.SziFalseTest = SziFalseTest;
                ViewBag.SziNullTest = SziNullTest;
            }
            #endregion
            #region  get Report from  phizic
            var phizic = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 10 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyphizic = 0;
            var StimeStudyphizic = 0;
            var SpTrueTest = 0;
            var SpFalseTest = 0;
            var SpNullTest = 0;
            foreach (var item in phizic)
            {
                timestudyphizic = item.TimeStudy + timestudyzist;
                StimeStudyphizic = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyphizic;
                ViewBag.timestudyphizic = timestudyphizic;
                ViewBag.StimeStudyphizic = StimeStudyphizic;
                SpTrueTest = SpTrueTest + item.Do.TrueTest;
                SpFalseTest = SpFalseTest + item.Do.falseTest;
                SpNullTest = SpNullTest + item.Do.NullTest;
                ViewBag.SpTrueTest = SpTrueTest;
                ViewBag.SpFalseTest = SpFalseTest;
                ViewBag.SpNullTest = SpNullTest;
            }
            #endregion
            #region  get Report from  shimi
            var shimi = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 11 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyshimi = 0;
            var StimeStudyshimi = 0;
            var SshTrueTest = 0;
            var SshFalseTest = 0;
            var SshNullTest = 0;
            foreach (var item in shimi)
            {
                timestudyshimi = item.TimeStudy + timestudyshimi;
                StimeStudyshimi = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyshimi;
                ViewBag.timestudyshimi = timestudyshimi;
                ViewBag.StimeStudyshimi = StimeStudyshimi;
                SshTrueTest = SshTrueTest + item.Do.TrueTest;
                SshFalseTest = SshFalseTest + item.Do.falseTest;
                SshNullTest = SshNullTest + item.Do.NullTest;
                ViewBag.SshTrueTest = SshTrueTest;
                ViewBag.SshFalseTest = SshFalseTest;
                ViewBag.SshNullTest = SshNullTest;
            }
            #endregion
            return View();
        }
        public IActionResult wReport(string id)
        {
            if (id == null)
            {
                RedirectToAction(nameof(Tasks));
            }
            var cid = _userManager.GetUserId(User);
            var day = DateTime.Today;
            var dayint = day.AddDays(-30);

            #region get Report from Math
            var Math = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 1 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyMath = 0;
            var StimeStudyMath = 0;
            var SMTrueTest = 0;
            var SMFalseTest = 0;
            var SMNullTest = 0;
            foreach (var item in Math)
            {
                timestudyMath = item.TimeStudy + timestudyMath;
                StimeStudyMath = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyMath;
                SMTrueTest = SMTrueTest + item.Do.TrueTest;
                SMFalseTest = SMFalseTest + item.Do.falseTest;
                SMNullTest = SMNullTest + item.Do.NullTest;
                ViewBag.timestudyMath = timestudyMath;
                ViewBag.StimeStudyMath = StimeStudyMath;
                ViewBag.SMTrueTest = SMTrueTest;
                ViewBag.SMFalseTest = SMFalseTest;
                ViewBag.SMNullTest = SMNullTest;
            }
            #endregion
            #region get Report from adab
            var adab = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 3 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyadab = 0;
            var StimeStudyadab = 0;
            var SATrueTest = 0;
            var SAFalseTest = 0;
            var SANullTest = 0;
            foreach (var item in adab)
            {
                timestudyadab = item.TimeStudy + timestudyadab;
                StimeStudyadab = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyadab;
                ViewBag.timestudyadab = timestudyadab;
                ViewBag.StimeStudyadab = StimeStudyadab;
                SATrueTest = SATrueTest + item.Do.TrueTest;
                SAFalseTest = SAFalseTest + item.Do.falseTest;
                SANullTest = SANullTest + item.Do.NullTest;
                ViewBag.SATrueTest = SATrueTest;
                ViewBag.SAFalseTest = SAFalseTest;
                ViewBag.SANullTest = SANullTest;
            }

            #endregion
            #region  get Report from zabanfarsi
            var zabanfarsi = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 4 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyzabanfarsi = 0;
            var StimeStudyzabanfarsi = 0;
            var SZTrueTest = 0;
            var SZFalseTest = 0;
            var SZNullTest = 0;
            foreach (var item in zabanfarsi)
            {
                timestudyzabanfarsi = item.TimeStudy + timestudyzabanfarsi;
                StimeStudyzabanfarsi = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyzabanfarsi;
                ViewBag.timestudyzabanfarsi = timestudyzabanfarsi;
                ViewBag.StimeStudyzabanfarsi = StimeStudyzabanfarsi;
                SZTrueTest = SZTrueTest + item.Do.TrueTest;
                SZFalseTest = SZFalseTest + item.Do.falseTest;
                SZNullTest = SZNullTest + item.Do.NullTest;
                ViewBag.SZTrueTest = SZTrueTest;
                ViewBag.SZFalseTest = SZFalseTest;
                ViewBag.SZNullTest = SZNullTest;
            }
            #endregion
            #region get Report from arabi
            var arabi = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 5 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyarabi = 0;
            var StimeStudyarabi = 0;
            var SaTrueTest = 0;
            var SaFalseTest = 0;
            var SaNullTest = 0;
            foreach (var item in arabi)
            {
                timestudyarabi = item.TimeStudy + timestudyarabi;
                StimeStudyarabi = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyarabi;
                ViewBag.timestudyarabi = timestudyarabi;
                ViewBag.StimeStudyarabi = StimeStudyarabi;
                SaTrueTest = SaTrueTest + item.Do.TrueTest;
                SaFalseTest = SaFalseTest + item.Do.falseTest;
                SaNullTest = SaNullTest + item.Do.NullTest;
                ViewBag.SaTrueTest = SaTrueTest;
                ViewBag.SaFalseTest = SaFalseTest;
                ViewBag.SaNullTest = SaNullTest;
            }
            #endregion
            #region  get Report from dinzendegi
            var dinzendegi = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 6 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudydinzendegi = 0;
            var StimeStudydinzendegi = 0;
            var SdTrueTest = 0;
            var SdFalseTest = 0;
            var SdNullTest = 0;
            foreach (var item in dinzendegi)
            {
                timestudydinzendegi = item.TimeStudy + timestudydinzendegi;
                StimeStudydinzendegi = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudydinzendegi;
                ViewBag.timestudydinzendegi = timestudydinzendegi;
                ViewBag.StimeStudydinzendegi = StimeStudydinzendegi;
                SdTrueTest = SdTrueTest + item.Do.TrueTest;
                SdFalseTest = SdFalseTest + item.Do.falseTest;
                SdNullTest = SdNullTest + item.Do.NullTest;
                ViewBag.SdTrueTest = SdTrueTest;
                ViewBag.SdFalseTest = SdFalseTest;
                ViewBag.SdNullTest = SdNullTest;
            }
            #endregion
            #region  get Report from english
            var english = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 7 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyenglish = 0;
            var StimeStudyenglish = 0;
            var SeTrueTest = 0;
            var SeFalseTest = 0;
            var SeNullTest = 0;
            foreach (var item in english)
            {
                timestudyenglish = item.TimeStudy + timestudyenglish;
                StimeStudyenglish = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyenglish;
                ViewBag.timestudyenglish = timestudyenglish;
                ViewBag.StimeStudyenglish = StimeStudyenglish;
                SeTrueTest = SeTrueTest + item.Do.TrueTest;
                SeFalseTest = SeFalseTest + item.Do.falseTest;
                SeNullTest = SeNullTest + item.Do.NullTest;
                ViewBag.SeTrueTest = SeTrueTest;
                ViewBag.SeFalseTest = SeFalseTest;
                ViewBag.SeNullTest = SeNullTest;
            }
            #endregion
            #region  get Report from zamin
            var zamin = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 8 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyzamin = 0;
            var StimeStudyzamin = 0;
            var SzTrueTest = 0;
            var SzFalseTest = 0;
            var SzNullTest = 0;
            foreach (var item in zamin)
            {
                timestudyzamin = item.TimeStudy + timestudyzamin;
                StimeStudyzamin = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyzamin;
                ViewBag.timestudyzamin = timestudyzamin;
                ViewBag.StimeStudyzamin = StimeStudyzamin;
                SzTrueTest = SzTrueTest + item.Do.TrueTest;
                SzFalseTest = SzFalseTest + item.Do.falseTest;
                SzNullTest = SzNullTest + item.Do.NullTest;
                ViewBag.SzTrueTest = SzTrueTest;
                ViewBag.SzFalseTest = SzFalseTest;
                ViewBag.SzNullTest = SzNullTest;
            }
            #endregion
            #region  get Report from zist
            var zist = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 9 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyzist = 0;
            var StimeStudyzist = 0;
            var SziTrueTest = 0;
            var SziFalseTest = 0;
            var SziNullTest = 0;
            foreach (var item in zist)
            {
                timestudyzist = item.TimeStudy + timestudyzist;
                StimeStudyzist = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyzist;
                ViewBag.timestudyzist = timestudyzist;
                ViewBag.StimeStudyzist = StimeStudyzist;
                SziTrueTest = SziTrueTest + item.Do.TrueTest;
                SziFalseTest = SziFalseTest + item.Do.falseTest;
                SziNullTest = SziNullTest + item.Do.NullTest;
                ViewBag.SziTrueTest = SziTrueTest;
                ViewBag.SziFalseTest = SziFalseTest;
                ViewBag.SziNullTest = SziNullTest;
            }
            #endregion
            #region  get Report from  phizic
            var phizic = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 10 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyphizic = 0;
            var StimeStudyphizic = 0;
            var SpTrueTest = 0;
            var SpFalseTest = 0;
            var SpNullTest = 0;
            foreach (var item in phizic)
            {
                timestudyphizic = item.TimeStudy + timestudyzist;
                StimeStudyphizic = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyphizic;
                ViewBag.timestudyphizic = timestudyphizic;
                ViewBag.StimeStudyphizic = StimeStudyphizic;
                SpTrueTest = SpTrueTest + item.Do.TrueTest;
                SpFalseTest = SpFalseTest + item.Do.falseTest;
                SpNullTest = SpNullTest + item.Do.NullTest;
                ViewBag.SpTrueTest = SpTrueTest;
                ViewBag.SpFalseTest = SpFalseTest;
                ViewBag.SpNullTest = SpNullTest;
            }
            #endregion
            #region  get Report from  shimi
            var shimi = _context.tbl_Tasks.Where(p => p.ConsultantId == cid && p.StudentId == id && p.DoIDdo != null && p.CourseIDCourse == 11 && p.SubmitDate >= dayint && p.SubmitDate <= DateTime.Today).Include(o => o.Do).ToList();
            var timestudyshimi = 0;
            var StimeStudyshimi = 0;
            var SshTrueTest = 0;
            var SshFalseTest = 0;
            var SshNullTest = 0;
            foreach (var item in shimi)
            {
                timestudyshimi = item.TimeStudy + timestudyshimi;
                StimeStudyshimi = (item.Do.DiscriptiveTime + item.Do.RevisionTime + item.Do.TestTime) + StimeStudyshimi;
                ViewBag.timestudyshimi = timestudyshimi;
                ViewBag.StimeStudyshimi = StimeStudyshimi;
                SshTrueTest = SshTrueTest + item.Do.TrueTest;
                SshFalseTest = SshFalseTest + item.Do.falseTest;
                SshNullTest = SshNullTest + item.Do.NullTest;
                ViewBag.SshTrueTest = SshTrueTest;
                ViewBag.SshFalseTest = SshFalseTest;
                ViewBag.SshNullTest = SshNullTest;
            }
            #endregion
            return View();
        }

    }
}
