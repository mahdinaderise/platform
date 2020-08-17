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
using WebPlatformV1.Migrations;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;
using WebPlatformV1.ViewModels.Consultant;

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
        public  IActionResult Index()
        {
            var cId = _userManager.GetUserId(User);
            
            var w = _context.tbl_Wallets.Where(p => p.ConsultantId == cId).ToList();
            if (w.Count == 0)
            {
                var Wallet = new Tbl_Wallet();
                Wallet.ConsultantId = cId;
                Wallet.Credit = 0;
                _context.tbl_Wallets.Add(Wallet);
                _context.SaveChanges();
            }
           
            //var result = _context.studentOfCansultants.Where(p => p.Cansultant.Equals(_userManager.GetUserId(User)));

            return View();
        }
        
        public IActionResult StudentPage(string id,TasksStudents model)
        {
            
            model.Students = _context.students.Where(p => p.Id == id).ToList();
            TempData["mydata"] = id;
            HttpContext.Session.SetString("id",id );

            var NowDateTime = DateTime.Today;
            var StartDate = model.StartDate;
            var EndDate = model.EndDate;
            model.tasks = _context.tbl_Tasks.Where(p => p.IdStudent == id && p.SendDelivery== DateTime.Today ).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentPage(TasksStudents model)
        {
            var id = HttpContext.Session.GetString("id");
            model.Students = _context.students.Where(p => p.Id == id).ToList();
            model.tasks = _context.tbl_Tasks.Where(p => p.IdStudent == id && p.SendDelivery == model.StartDate ).ToList();

            return View(model);
        }

        public IActionResult detaildo(int id,detaildo model)
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
            model.blog = _context.tbl_Blogs.Where(p => p.ConsultantId == consultantId).OrderByDescending(P=>P.ID).ToList();
            model.Name = result.Name;
            model.Family = result.Family;
            model.Email = result.Email;
            model.id = result.Id;
            string FristLast = result.Family;
            string fristCharecter = result.Name;
            ViewBag.fristCharecter = fristCharecter[0]+" " +FristLast[0].ToString();
            model.ProfilePicUrl = result.ProfilePicUrl;
            model.CountPost = _context.tbl_Blogs.Where(p=>p.ConsultantId== consultantId).Count();
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
        public async Task<IActionResult> EditPost(int id,[Bind("ID","Note") ] Tbl_Blog model)
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
        public IActionResult CreateTask( CreateTask model,Tbl_Tasks tasks)
        {
            var NowDateTime = DateTime.Today;
            var id = HttpContext.Session.GetString("id");
            ViewData["course"] = new SelectList(_context.tbl_Courses, "IDCourse", "NameCourse",tasks.Idcourse );

            model.tasks = _context.tbl_Tasks.Where(p => p.IdStudent == id && p.SubmitDate == NowDateTime).ToList();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTask(CreateTask model, Tbl_Tasks tasks,string? name)
        {
            var id = HttpContext.Session.GetString("id");

            if (ModelState.IsValid)
            {
                tasks.Descibtion = model.Descibtion;
                tasks.NameTasks = model.NameTasks;
                tasks.Subject = model.Subject;
                tasks.IdConsultant= _userManager.GetUserId(User);
                tasks.IdStudent = id;
                tasks.Idcourse = model.courseid;
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
            if (r!=0)
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
        public async Task<IActionResult> haspanel( string id)
        {
            id = HttpContext.Session.GetString("IdStudentForPanel");
            var panel =  _context.tbl_AddPanels.Where(p=>p.StudentID==id);
            
            //_context.tbl_AddPanels.Remove(panel);
         await _context.SaveChangesAsync();
         return RedirectToAction(nameof(AddPanel));

            return View();
        }
      
      
   [HttpGet]
        public   IActionResult Profile(Profile model)
        {
 
            var consultantId = _userManager.GetUserId(User);

          var C=  _context.Find<Consultant>(consultantId);
            //var user = _context.consultants.Select(p=>p.Name  p.Family , p.PhoneNumber).Where(p => p.Id == consultantId).ToList();

            #region view data in textbox


            model.id = C.Id;
            model.Name = C.Name;
            model.Family = C.Family;
            model.Address = C.Address;
            model.CardNumber = C.CardNumber;
            model.PhoneNumber = C.PhoneNumber;
            model.Shaba = C.Shaba;
            model.ProfilePicUrl = C.ProfilePicUrl;

            #endregion

            #region get on char of name and family

            //model.Consultants = _context.consultants.Where(p => p.Id == user).ToList();
            //consultants = _context.consultants.Where(p=>p.Id==id).ToList();
            string FristLast = model.Family;
            string fristCharecter = model.Name;
            ViewBag.fristCharecter = fristCharecter[0] + " " + FristLast[0].ToString();

            #endregion

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(Profile model,Consultant consultant)
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
                await _context.SaveChangesAsync();
                if (model.Picture?.Length > 0)
                {
                    string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                        "wwwroot",
                        "images","Profile",

                        c.Id + Path.GetExtension(model.Picture.FileName));
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Picture.CopyTo(stream);
                        var test = filePath;
                        c.ProfilePicUrl = filePath;
                        await _context.SaveChangesAsync();

                        consultant.ProfilePicUrl = model.Picture.ToString();                    }
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
    }
}
