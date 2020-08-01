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
            TempData["mydata"] = id;
            HttpContext.Session.SetString("id",id );

            var NowDateTime = DateTime.Today;
            var StartDate = model.StartDate;
            var EndDate = model.EndDate;
            model.tasks = _context.tbl_Tasks.Where(p => p.IdStudent == id && p.SendDelivery== DateTime.Today ).ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult StudentPage(TasksStudent model)
        {
            var id = HttpContext.Session.GetString("id");
            model.Students = _context.students.Where(p => p.Id == id).ToList();
            model.tasks = _context.tbl_Tasks.Where(p => p.IdStudent == id && p.SendDelivery == model.StartDate ).ToList();

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
        public IActionResult blog()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateTask( CreateTask model)
        {
            var NowDateTime = DateTime.Today;
            var id = HttpContext.Session.GetString("id");
            ViewData["course"] = new SelectList(_context.tbl_Courses, "IDCourse", "NameCourse");

            model.tasks = _context.tbl_Tasks.Where(p => p.IdStudent == id && p.SubmitDate == NowDateTime).ToList();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTask(CreateTask model, Tbl_Tasks tasks)
        {
            var id = HttpContext.Session.GetString("id");
            if (ModelState.IsValid)
            {
                tasks.Descibtion = model.Descibtion;
                tasks.NameTasks = model.NameTasks;
                tasks.Subject = model.Subject;
                tasks.IdConsultant= _userManager.GetUserId(User);
                tasks.IdStudent = id;
                tasks.Idcourse = 1;
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
