using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;
using WebPlatformV1.ViewModels;
using WebPlatformV1.ViewModels.Consultant;
using WebPlatformV1.ViewModels.StudentViewModel;
using ZarinpalSandbox;

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
         public IActionResult PeyTest()
        {
            return View();
        }
        public IActionResult course()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ido(int id)
        {
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
        public IActionResult index(todoapp model)
        {
            #region check credit
            var IdStudent = _userManager.GetUserId(User);
            var r = _context.students.Find(IdStudent);
            ViewBag.myid = IdStudent;
            if (r.CreditTime<DateTime.Today)
            {
                return RedirectToAction(nameof(MyPanel));

            }
            #endregion
            #region count of credit
            var credittime = r.CreditTime.DayOfYear;
            var Today = DateTime.Today.DayOfYear;
            ViewBag.credittime = credittime - Today;
            #endregion
            #region count of do task
            var tasks = _context.tbl_Tasks.Where(p => p.StudentId == IdStudent).Count();
            var tasksdo = _context.tbl_Tasks.Where(p => p.StudentId == IdStudent && p.isDo == true).Count();
            var tasksNdo = _context.tbl_Tasks.Where(p => p.StudentId == IdStudent && p.isDo == false).Count();
            var todayTask= _context.tbl_Tasks.Where(p => p.SendDelivery == DateTime.Today).Count();
            ViewBag.DoTest = (tasksdo * 100) / tasks;
            ViewBag.NDoTest = ( tasksNdo * 100) / tasks;
            ViewBag.Tasks = tasks;
            ViewBag.tasksdo = tasksdo;
            ViewBag.today = todayTask;
            #endregion
            model.Todo = _context.Tbl_TodoAppStudents.Where(p => p.STudentID == IdStudent).ToList();
            //ViewBag.todoid = model.Todo.Where(p => p.STudentID == IdStudent).Select(p => p.Id);

            return View(model);
        }
        [HttpGet]
        public IActionResult studenttask(TasksStudents model)
        { 
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
        {
            var studentId = _userManager.GetUserId(User);
            var panel = _context.tbl_AddPanels.Where(p => p.StudentID == studentId).OrderByDescending(p => p.IDAddPanel).FirstOrDefault();
            if (panel == null)
                return NotFound();
            var payment = new ZarinpalSandbox.Payment(panel.Price);
            var res = payment.PaymentRequest($"پرداخت فاکتور شماره {panel.IDAddPanel}",
               "http://localhost:5000/Student/OnlinePayment/" + panel.IDAddPanel, "Mahdinaderi.se@outlook.com", "09130087194");
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
        public IActionResult OnlinePayment(int id)
        {
            var studentId = _userManager.GetUserId(User);

            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok" &&
                HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"].ToString();
                var panel = _context.tbl_AddPanels.Where(p => p.StudentID == studentId).OrderByDescending(p => p.IDAddPanel).FirstOrDefault();
                var student = _context.students.FirstOrDefault(p => p.Id == studentId);
                var ConsultantWallet = _context.tbl_Wallets.FirstOrDefault(p => p.ConsultantId == student.ConsultantID);
                DateTime today = DateTime.Today;
              DateTime  CreditTime1= today.AddDays(panel.Day);
                var payment = new Payment(panel.Price);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    ConsultantWallet.Credit = ConsultantWallet.Credit + panel.Price;
                    student.CreditTime= CreditTime1;
                    panel.Status = true;
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
            var studentId = _userManager.GetUserId(User);
            model.Panel1 = _context.tbl_AddPanels.Where(p => p.StudentID == studentId).OrderByDescending(p => p.IDAddPanel).FirstOrDefault();
            if (model.Panel1!=null)
            {
                model.price = model.Panel1.Price / model.Panel1.Day;

            }
            return View(model);
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
        public async Task<IActionResult> TodoAppupdate(todoapp model, Tbl_TodoAppStudent todo)
        {
            var studentId = _userManager.GetUserId(User);
            todo.Note = model.Note;
            todo.STudentID = model.STudentID;
            todo.IsFinally = model.IsFinally;
            todo.Id = model.id;
             _context.Tbl_TodoAppStudents.Update(todo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(index));
        }
    }
}