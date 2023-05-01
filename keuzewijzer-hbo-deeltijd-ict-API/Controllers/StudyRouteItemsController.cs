using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;

namespace keuzewijzer_hbo_deeltijd_ict_API.Controllers
{
    public class StudyRouteItemsController : Controller
    {
        private readonly UserContext _context;

        public StudyRouteItemsController(UserContext context)
        {
            _context = context;
        }

        // GET: StudyRouteItems
        public async Task<IActionResult> Index()
        {
            var userContext = _context.StudyRouteItem.Include(s => s.StudyRoute);
            return View(await userContext.ToListAsync());
        }

        // GET: StudyRouteItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StudyRouteItem == null)
            {
                return NotFound();
            }

            var studyRouteItem = await _context.StudyRouteItem
                .Include(s => s.StudyRoute)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studyRouteItem == null)
            {
                return NotFound();
            }

            return View(studyRouteItem);
        }

        // GET: StudyRouteItems/Create
        public IActionResult Create()
        {
            ViewData["StudyRouteId"] = new SelectList(_context.StudyRoute, "Id", "Id");
            return View();
        }

        // POST: StudyRouteItems/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Year,Semester,StudyRouteId")] StudyRouteItem studyRouteItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studyRouteItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudyRouteId"] = new SelectList(_context.StudyRoute, "Id", "Id", studyRouteItem.StudyRouteId);
            return View(studyRouteItem);
        }

        // GET: StudyRouteItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StudyRouteItem == null)
            {
                return NotFound();
            }

            var studyRouteItem = await _context.StudyRouteItem.FindAsync(id);
            if (studyRouteItem == null)
            {
                return NotFound();
            }
            ViewData["StudyRouteId"] = new SelectList(_context.StudyRoute, "Id", "Id", studyRouteItem.StudyRouteId);
            return View(studyRouteItem);
        }

        // POST: StudyRouteItems/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Year,Semester,StudyRouteId")] StudyRouteItem studyRouteItem)
        {
            if (id != studyRouteItem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studyRouteItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudyRouteItemExists(studyRouteItem.Id))
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
            ViewData["StudyRouteId"] = new SelectList(_context.StudyRoute, "Id", "Id", studyRouteItem.StudyRouteId);
            return View(studyRouteItem);
        }

        // GET: StudyRouteItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StudyRouteItem == null)
            {
                return NotFound();
            }

            var studyRouteItem = await _context.StudyRouteItem
                .Include(s => s.StudyRoute)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studyRouteItem == null)
            {
                return NotFound();
            }

            return View(studyRouteItem);
        }

        // POST: StudyRouteItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StudyRouteItem == null)
            {
                return Problem("Entity set 'UserContext.StudyRouteItem'  is null.");
            }
            var studyRouteItem = await _context.StudyRouteItem.FindAsync(id);
            if (studyRouteItem != null)
            {
                _context.StudyRouteItem.Remove(studyRouteItem);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudyRouteItemExists(int id)
        {
          return (_context.StudyRouteItem?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
