using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPlatformV1.Models.DbContext;

namespace WebPlatformV1.Controllers
{
    public class Tbl_TasksController : Controller
    {
        private readonly MainDBContext _context;

        public Tbl_TasksController(MainDBContext context)
        {
            _context = context;
        }

        // GET: Tbl_Tasks
        public async Task<IActionResult> Index()
        {
            return View(await _context.tbl_Tasks.ToListAsync());
        }

        // GET: Tbl_Tasks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbl_Tasks = await _context.tbl_Tasks
                .FirstOrDefaultAsync(m => m.IDTasks == id);
            if (tbl_Tasks == null)
            {
                return NotFound();
            }

            return View(tbl_Tasks);
        }

        // GET: Tbl_Tasks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tbl_Tasks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IDTasks,IDCansoltant,IDStudent,IDido,NameTasks,SendDelivery")] Tbl_Tasks tbl_Tasks)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tbl_Tasks);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tbl_Tasks);
        }

        // GET: Tbl_Tasks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbl_Tasks = await _context.tbl_Tasks.FindAsync(id);
            if (tbl_Tasks == null)
            {
                return NotFound();
            }
            return View(tbl_Tasks);
        }

        // POST: Tbl_Tasks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IDTasks,IDCansoltant,IDStudent,IDido,NameTasks,SendDelivery")] Tbl_Tasks tbl_Tasks)
        {
            if (id != tbl_Tasks.IDTasks)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tbl_Tasks);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Tbl_TasksExists(tbl_Tasks.IDTasks))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tbl_Tasks);
        }

        // GET: Tbl_Tasks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tbl_Tasks = await _context.tbl_Tasks
                .FirstOrDefaultAsync(m => m.IDTasks == id);
            if (tbl_Tasks == null)
            {
                return NotFound();
            }

            return View(tbl_Tasks);
        }

        // POST: Tbl_Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tbl_Tasks = await _context.tbl_Tasks.FindAsync(id);
            _context.tbl_Tasks.Remove(tbl_Tasks);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Tbl_TasksExists(int id)
        {
            return _context.tbl_Tasks.Any(e => e.IDTasks == id);
        }
    }
}
