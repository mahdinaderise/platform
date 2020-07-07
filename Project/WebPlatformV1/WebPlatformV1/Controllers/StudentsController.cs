using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebPlatformV1.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult course()
        {
            return View();
        }
        public IActionResult ido()
        {
            return View();
        }
        public IActionResult index()
        {
            return View();
        }
        public IActionResult studenttask()
        {
            return View();
        }
        public IActionResult students()
        {
            return View();
        }
    }
}