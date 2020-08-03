using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;
using WebPlatformV1.ViewModels;
using WebPlatformV1.ViewModels.Consultant;

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

        public IActionResult course()
        {
            return View();
        }
        public IActionResult ido()
        {
            //مهدی نادری سیمیرمی
            return View();
        }
        public IActionResult index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult studenttask(TasksStudents model)
        { 
        var IdStudent = _userManager.GetUserId(User);
            var NowDateTime = DateTime.Today;
            var StartDate = model.StartDate;
            model.tasks = _context.tbl_Tasks.Where(p => p.IdStudent == IdStudent && p.SendDelivery == DateTime.Today).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult studenttask(TasksStudents model,string? id)
        {
            var IdStudent = _userManager.GetUserId(User);

            model.Students = _context.students.Where(p => p.Id == IdStudent).ToList();
            model.tasks = _context.tbl_Tasks.Where(p => p.IdStudent == IdStudent && p.SendDelivery == model.StartDate).ToList();

            return View(model);
        }
        public IActionResult students()
        {
            return View();
        }
    }
}