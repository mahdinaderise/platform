using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using WebPlatformV1.Migrations;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;
using WebPlatformV1.ViewModels;
using WebPlatformV1.ViewModels.Consultant;
using WebPlatformV1.ViewModels.ConsultantViewModel;
using WebPlatformV1.ViewModels.StudentViewModel;
using Zarinpal;

namespace WebPlatformV1.Controllers
{
    [Authorize(Roles = "Student")]

    public class StudentController : Controller
    {
        private readonly MainDBContext _context;
        private readonly UserManager<ApplicationUsers> _userManager;

        public StudentController(MainDBContext context, UserManager<ApplicationUsers> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult index(todoapp model)
        {
            #region menuDt
            var sId = _userManager.GetUserId(User);

            var students = _context.students.FirstOrDefault(p => p.Id == sId);
            var name = students.Name;
            var Family = students.Family;
            ViewBag.NameAndFamily = name + " " + Family;
            ViewBag.fristCharecter = name[0] + " " + Family[0].ToString();
            ViewBag.hasP = students.ProfilePicUrl;
            #endregion

            #region check credit
            var IdStudent = _userManager.GetUserId(User);
            var r = _context.students.Find(IdStudent);
            ViewBag.myid = IdStudent;

            if (r.ConsultantID == null)
            {
                return RedirectToAction(nameof(SelectConsultant));

            }

            if (r.CreditTime < DateTime.Today)
            {
                if (r.State == true)
                {
                    r.State = false;
                    _context.students.Update(r);
                    _context.SaveChanges();
                }

                return RedirectToAction(nameof(MyPanel));

            }
            #endregion
            #region count of credit
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
            #endregion
            #region count of do task
            var tasks = _context.tbl_Tasks.Where(p => p.StudentId == IdStudent).Count();
            var tasksdo = _context.tbl_Tasks.Where(p => p.StudentId == IdStudent && p.isDo == true).Count();
            var tasksNdo = _context.tbl_Tasks.Where(p => p.StudentId == IdStudent && p.isDo == false).Count();
            var todayTask = _context.tbl_Tasks.Where(p => p.SendDelivery == DateTime.Today).Count();
            if (tasks != 0)
            {
                ViewBag.DoTest = (tasksdo * 100) / tasks;
                ViewBag.NDoTest = (tasksNdo * 100) / tasks;
            }
            else
            {
                ViewBag.DoTest = 0;
                ViewBag.NDoTest = 0;
            }
            ViewBag.Tasks = tasks;
            ViewBag.tasksdo = tasksdo;
            ViewBag.today = todayTask;
            #endregion
            model.Todo = _context.Tbl_TodoAppStudents.Where(p => p.STudentID == IdStudent).ToList();
            //ViewBag.todoid = model.Todo.Where(p => p.STudentID == IdStudent).Select(p => p.Id);

            return View(model);
        }
        public IActionResult PeyTest()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Profile(Profile model)
        {
            #region menuDt
            var sId = _userManager.GetUserId(User);

            var students = _context.students.FirstOrDefault(p => p.Id == sId);
            var name = students.Name;
            var Family = students.Family;
            ViewBag.NameAndFamily = name + " " + Family;
            ViewBag.fristCharecter = name[0] + " " + Family[0].ToString();
            ViewBag.hasP = students.ProfilePicUrl;
            #endregion

            var studentid = _userManager.GetUserId(User);

            var C = _context.Find<Student>(studentid);
            //var user = _context.consultants.Select(p=>p.Name  p.Family , p.PhoneNumber).Where(p => p.Id == consultantId).ToList();
            #region view data in textbox


            model.id = C.Id;
            model.Name = C.Name;
            model.Family = C.Family;
            model.PhoneNumber = C.PhoneNumber;
            model.ProfilePicUrl = C.ProfilePicUrl;
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
            var studentId = _userManager.GetUserId(User);
            var s = _context.students.FirstOrDefault(p => p.Id == studentId);
            if (s != null)
            {
                s.Name = model.Name;
                s.Family = model.Family;
               
                s.PhoneNumber = model.PhoneNumber;
               
                await _context.SaveChangesAsync();
                if (model.Picture?.Length > 0)
                {
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "images", "Profile",

                        s.Id + Path.GetExtension(model.Picture.FileName));
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Picture.CopyTo(stream);
                        var test = filePath;
                        s.ProfilePicUrl = filePath;
                        await _context.SaveChangesAsync();

                        consultant.ProfilePicUrl = model.Picture.ToString();
                    }
                }

                return RedirectToAction(nameof(Profile));

            }


            return View(model);
        }
        public IActionResult course()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ido(int id)
        {
            #region menuDt
            var sId = _userManager.GetUserId(User);

            var students = _context.students.FirstOrDefault(p => p.Id == sId);
            var name = students.Name;
            var Family = students.Family;
            ViewBag.NameAndFamily = name + " " + Family;
            ViewBag.fristCharecter = name[0] + " " + Family[0].ToString();
            ViewBag.hasP = students.ProfilePicUrl;
            #endregion
            HttpContext.Session.SetInt32("id", id);

            return View();
        }
        [HttpPost]
        public async Task< IActionResult> ido(Tbl_Do _Do , DoTask model,Tbl_Tasks tasks)
        { var id= HttpContext.Session.GetInt32("id");
            //var tasks = _context.tbl_Tasks.Where(p => p.IDTasks == (int)id).ToList();
          
            _context.tbl_Tasks.Update(tasks);
            
            if (ModelState.IsValid)
            {
                _Do.IDTasks = (int)id;
                _Do.DiscriptiveTime = model.DiscriptiveTime;
                _Do.Note = model.Note;
                _Do.TrueTest = model.TrueTest;
                _Do.falseTest = model.falseTest;
                _Do.NullTest = model.NullTest;
                _Do.TestTime = model.TestTime;
                _Do.RevisionTime = model.RevisionTime;
              
                await _context.AddAsync(_Do);
                await _context.SaveChangesAsync();
                tasks = _context.Find<Tbl_Tasks>((int)id);
                tasks.isDo = true;
                tasks.DoIDdo = _Do.IDdo;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(studenttask));
            }
          

            return View();
        }
    
        [HttpGet]
        public IActionResult studenttask(TasksStudents model)
        {
            #region menuDt
            var sId = _userManager.GetUserId(User);

            var students = _context.students.FirstOrDefault(p => p.Id == sId);
            var name = students.Name;
            var Family = students.Family;
            ViewBag.NameAndFamily = name + " " + Family;
            ViewBag.fristCharecter = name[0] + " " + Family[0].ToString();
            ViewBag.hasP = students.ProfilePicUrl;
            #endregion
            var IdStudent = _userManager.GetUserId(User);
            var NowDateTime = DateTime.Today;
            var StartDate = model.StartDate;
            model.tasks = _context.tbl_Tasks.Where(p => p.StudentId == IdStudent && p.SendDelivery == DateTime.Today).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult studenttask(TasksStudents model,string? id)
        {
            var IdStudent = _userManager.GetUserId(User);

            model.Students = _context.students.Where(p => p.Id == IdStudent).ToList();
            model.tasks = _context.tbl_Tasks.Where(p => p.StudentId == IdStudent && p.SendDelivery == model.StartDate).ToList();

            return View(model);
        }
        public IActionResult students()
        {
            return View();
        }
        public IActionResult Peyment()
        { var merchan = "2ae499a0-1e82-47eb-9208-d099026ef22a";
            var studentId = _userManager.GetUserId(User);
            var student = _context.students.FirstOrDefault(p => p.Id == studentId);
            var panel = _context.tbl_AddPanels.Where(p => p.StudentID == studentId).OrderByDescending(p => p.IDAddPanel).FirstOrDefault();
            if (panel == null)
                return NotFound();
            var payment = new Zarinpal.Payment(merchan, panel.Price);
            var res = payment.PaymentRequest($"پرداخت فاکتور شماره {panel.IDAddPanel}",
               "http://panel.moshaviran.com/Student/OnlinePayment/" + panel.IDAddPanel, student.Email,student.PhoneNumber);
            if (res.Result.Status == 100)
            {
                return Redirect("https://zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }
            else
            {
                return BadRequest();
            }
            return View();
        }
        public IActionResult OnlinePayment(int id)
        {
         var merchan = "2ae499a0-1e82-47eb-9208-d099026ef22a";

            #region menuDt
            var sId = _userManager.GetUserId(User);

            var students = _context.students.FirstOrDefault(p => p.Id == sId);
            var name = students.Name;
            var Family = students.Family;
            ViewBag.NameAndFamily = name + " " + Family;
            ViewBag.fristCharecter = name[0] + " " + Family[0].ToString();
            ViewBag.hasP = students.ProfilePicUrl;
            #endregion
            var studentId = _userManager.GetUserId(User);

            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok" &&
                HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"].ToString();
                var panel = _context.tbl_AddPanels.Where(p => p.StudentID == studentId).OrderByDescending(p => p.IDAddPanel).FirstOrDefault();
                var student = _context.students.FirstOrDefault(p => p.Id == studentId);
                var ConsultantWallet = _context.tbl_Wallets.FirstOrDefault(p => p.ConsultantId == student.ConsultantID);
                var Balance = _context.Tbl_Balances.Find(1);
                DateTime today = DateTime.Today;
              DateTime  CreditTime1= today.AddDays(panel.Day);
                var payment = new Payment(merchan, panel.Price);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    Tbl_HistoryPey historyPey = new Tbl_HistoryPey();
                    historyPey.DatePey = DateTime.Today;
                    historyPey.Peyamount = panel.Price;
                    var Darsad = (panel.Price * 5) / 100;
                    var Result = panel.Price - Darsad;
                    Balance.SumComosion = Balance.SumComosion + Darsad;
                    student.State = true;
                    historyPey.comision = Darsad;
                    historyPey.RefId = res.RefId;
                    historyPey.ConsultantId = ConsultantWallet.ConsultantId;
                    ConsultantWallet.Credit = ConsultantWallet.Credit + Result;
                    student.CreditTime= CreditTime1;
                    panel.Status = true;
                    _context.Tbl_Balances.Update(Balance);
                    _context.Tbl_HistoryPeys.Add(historyPey);
                    _context.students.Update(student);
                    _context.tbl_Wallets.Update(ConsultantWallet);

                    _context.tbl_AddPanels.Update(panel);
                    _context.SaveChanges();
                    ViewBag.code = res.RefId;
                    return View();
                }
            }

            return NotFound();
        }
        public IActionResult MyPanel(Panel model)
        {
            #region menuDt
            var sId = _userManager.GetUserId(User);

            var students = _context.students.FirstOrDefault(p => p.Id == sId);
            var name = students.Name;
            var Family = students.Family;
            ViewBag.NameAndFamily = name + " " + Family;
            ViewBag.fristCharecter = name[0] + " " + Family[0].ToString();
            ViewBag.hasP = students.ProfilePicUrl;
            #endregion
            var studentId = _userManager.GetUserId(User);
            model.Panel1 = _context.tbl_AddPanels.Where(p => p.StudentID == studentId).OrderByDescending(p => p.IDAddPanel).FirstOrDefault();
            ViewBag.hasconsultant = _context.students.FirstOrDefault(p => p.Id == studentId).ConsultantID;
            if (model.Panel1!=null)
            {
                model.price = model.Panel1.Price / model.Panel1.Day;

            }
            return View(model);
        }
        public IActionResult DeleteConsultant()
        {
            var studentId = _userManager.GetUserId(User);
            var student = _context.students.FirstOrDefault(p => p.Id == studentId);
            student.State = false;
            student.ConsultantID = null;
            _context.students.Update(student);
            _context.SaveChanges();
            return RedirectToAction(nameof(MyPanel));
        }
        [HttpPost]
        public async Task<IActionResult> TodoApp(todoapp model,Tbl_TodoAppStudent todo)
        {
            var studentId = _userManager.GetUserId(User);
            todo.Note = model.Note;
            todo.STudentID = model.STudentID;
            todo.IsFinally = model.IsFinally;
            
            await _context.Tbl_TodoAppStudents.AddAsync(todo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(index));
        }
        [HttpPost]
        public async Task<IActionResult> TodoAppupdate(todoapp model, Tbl_TodoAppStudent todo)
        {
            var studentId = _userManager.GetUserId(User);
            todo.Note = model.Note;
            todo.STudentID = model.STudentID;
            todo.IsFinally = true;
            todo.Id = model.id;
             _context.Tbl_TodoAppStudents.Update(todo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(index));
        }
        public IActionResult SelectConsultant()
        {
            #region menuDt
            var sId = _userManager.GetUserId(User);

            var students = _context.students.FirstOrDefault(p => p.Id == sId);
            var name = students.Name;
            var Family = students.Family;
            ViewBag.NameAndFamily = name + " " + Family;
            ViewBag.fristCharecter = name[0] + " " + Family[0].ToString();
            ViewBag.hasP = students.ProfilePicUrl;
            #endregion
            var studentId = _userManager.GetUserId(User);

            ViewBag.hasconsultant = _context.students.FirstOrDefault(p => p.Id == studentId).ConsultantID;
            
            var consultants = new List<Consultant>();
            consultants = _context.consultants.Where(p => p.State == true && p.IsSendDegree == true && p.isAcceptDegree == true).ToList();
            return View(consultants);
        }
        public IActionResult ConsultantPage(string id, requestforonline model)
        {
            #region menuDt
            var sId = _userManager.GetUserId(User);

            var students = _context.students.FirstOrDefault(p => p.Id == sId);
            var name = students.Name;
            var Family = students.Family;
            ViewBag.NameAndFamily = name + " " + Family;
            ViewBag.fristCharecter = name[0] + " " + Family[0].ToString();
            ViewBag.hasP = students.ProfilePicUrl;
            #endregion
            var consultant = _context.consultants.FirstOrDefault(p => p.Id == id);
            ViewBag.NameF = consultant.Name + " " + consultant.Family;
            ViewBag.CountRequest = _context.students.Where(p => p.ConsultantID == id).Count();
            model.bio = consultant.Bio;
            model.about = consultant.about;
            model.id = consultant.Id;
            return View(model);

        }
        public IActionResult Blog(Blog model)
        {
            #region menuDt
            var sId = _userManager.GetUserId(User);

            var students = _context.students.FirstOrDefault(p => p.Id == sId);
            var name = students.Name;
            var Family = students.Family;
            ViewBag.NameAndFamily = name + " " + Family;
            ViewBag.fristCharecter = name[0] + " " + Family[0].ToString();
            ViewBag.hasP = students.ProfilePicUrl;
            #endregion
            if (students.ConsultantID == null)
            {
                return RedirectToAction(nameof(SelectConsultant));

            }

            if (students.CreditTime < DateTime.Today)
            {
                if (students.State == true)
                {
                    students.State = false;
                    _context.students.Update(students);
                    _context.SaveChanges();
                }

                return RedirectToAction(nameof(MyPanel));

            }
            var result = _context.consultants.FirstOrDefault(p => p.Id == students.ConsultantID);
            model.blog = _context.tbl_Blogs.Where(p => p.ConsultantId == result.Id).OrderByDescending(P => P.ID).ToList();
            model.Name = result.Name;
            model.Family = result.Family;
            model.Email = result.Email;
            model.id = result.Id;
            string FristLast = result.Family;
            string fristCharecter = result.Name;
            ViewBag.fristCharecter = fristCharecter[0] + " " + FristLast[0].ToString();
            model.ProfilePicUrl = result.ProfilePicUrl;
            model.CountPost = _context.tbl_Blogs.Where(p => p.ConsultantId == result.Id).Count();
            model.CountStudent = _context.students.Where(p => p.ConsultantID == result.Id).Count();
            return View(model);
        }
        public IActionResult AcceptConsultant(string id, requestforonline model)
        {
            var studentId = _userManager.GetUserId(User);
            var student = _context.students.FirstOrDefault(p => p.Id == studentId);
            student.ConsultantID = id;
            _context.students.Update(student);
            _context.SaveChanges();
            return RedirectToAction(nameof(index));
        }
        [HttpPost]
        public IActionResult ConsultantPage(string id, requestforonline model,Tbl_RequestonlineclassStudent Req)
        {
            var studentId = _userManager.GetUserId(User);
            var consultant = _context.consultants.FirstOrDefault(p => p.Id == id);

            ViewBag.NameF = consultant.Name + " " + consultant.Family;
            ViewBag.CountRequest = _context.students.Where(p => p.ConsultantID == id).Count();
            Req.ConsultantID = id;
            Req.RequestTextStudent = model.RequestText;
            Req.statusForConsultant = false;
            Req.StudentID = studentId;
            model.bio = consultant.Bio;
            model.about = consultant.about;
            model.id = consultant.Id;
            _context.tbl_Requestonlineclasses.Add(Req);
            _context.SaveChanges();
            ViewBag.succeseReq = "درخواست شما با موفقیت ثبت شد زمان کلاس انلاین به شماره تلفن شما ارسال می شود.";
            return View(model);
        }
    }
}