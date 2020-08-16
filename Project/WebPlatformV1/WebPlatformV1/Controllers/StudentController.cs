using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebPlatformV1.Models;
using WebPlatformV1.Models.DbContext;
using WebPlatformV1.ViewModels;
using WebPlatformV1.ViewModels.Consultant;
using WebPlatformV1.ViewModels.StudentViewModel;

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
                tasks.IdoId = _Do.IDdo;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(studenttask));
            }
          

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