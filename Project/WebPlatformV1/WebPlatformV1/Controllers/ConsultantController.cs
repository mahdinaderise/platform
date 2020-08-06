﻿using System;
using System.Collections.Generic;
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
            model.Name = result.Name;
            model.Family = result.Family;
            model.Email = result.Email;
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
                return RedirectToAction(nameof(blog));
            }
            return View();
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
