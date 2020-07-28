using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            //var result = _context.studentOfCansultants.Where(p => p.Cansultant.Equals(_userManager.GetUserId(User)));
           
            return View();
        }
        
        public IActionResult StudentPage(string id,TasksStudent model)
        {
            model.Students = _context.students.Where(p => p.Id == id).ToList();
            var NowDateTime = DateTime.Today;
            var StartDate = model.StartDate;
            var EndDate = model.EndDate;
            model.tasks = _context.tbl_Tasks.Where(p => p.Student.Id == id &&(p.SendDelivery == NowDateTime || p.SendDelivery == StartDate )).ToList();
            return View(model);
        }

        public IActionResult Save(TasksStudent model)
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult StudentPage(string id, TasksStudent model)
        //{
        //    model.Students = _context.students.Where(p => p.Id == id).ToList();
        //    var NowDateTime = DateTime.Today;

        //    model.tasks = _context.tbl_Tasks.Where(p => p.Student.Id == id && p.SendDelivery == NowDateTime).ToList();
        //    return View(model);
        //}
        public IActionResult blog()
        {
            return View();
        }
        public IActionResult CreateTask()
        {
            return View();
        }
        public IActionResult paymanagment()
        {
            return View();
        }
        public IActionResult students()
        {
            return View();
        }
        public IActionResult Tasks(StudentsViewModel model)
        {
            var consultantId = _userManager.GetUserId(User);
            model.Students = _context.students.Where(p => p.ConsultantID == consultantId).ToList();

            return View(model);
        }
    }
}
