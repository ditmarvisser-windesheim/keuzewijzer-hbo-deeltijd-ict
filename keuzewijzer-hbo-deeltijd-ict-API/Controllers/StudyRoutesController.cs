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
    public class StudyRoutesController : Controller
    {
        private readonly UserContext _context;

        public StudyRoutesController(UserContext context)
        {
            _context = context;
        }

        // GET: StudyRoutes
        public async Task<IActionResult> Index()
        {
            var userContext = _context.StudyRoute.Include(s => s.User);
            return View(await userContext.ToListAsync());
        }

        // GET: StudyRoutes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.StudyRoute == null)
            {
                return NotFound();
            }

            var studyRoute = await _context.StudyRoute
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studyRoute == null)
            {
                return NotFound();
            }

            return View(studyRoute);
        }

        // GET: StudyRoutes/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: StudyRoutes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Approved_sb,Approved_eb,Note,Send_sb,Send_eb,UserId")] StudyRoute studyRoute)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studyRoute);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", studyRoute.UserId);
            return View(studyRoute);
        }

        // GET: StudyRoutes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StudyRoute == null)
            {
                return NotFound();
            }

            var studyRoute = await _context.StudyRoute.FindAsync(id);
            if (studyRoute == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", studyRoute.UserId);
            return View(studyRoute);
        }

        // POST: StudyRoutes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Approved_sb,Approved_eb,Note,Send_sb,Send_eb,UserId")] StudyRoute studyRoute)
        {
            if (id != studyRoute.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studyRoute);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudyRouteExists(studyRoute.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", studyRoute.UserId);
            return View(studyRoute);
        }

        // GET: StudyRoutes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.StudyRoute == null)
            {
                return NotFound();
            }

            var studyRoute = await _context.StudyRoute
                .Include(s => s.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studyRoute == null)
            {
                return NotFound();
            }

            return View(studyRoute);
        }

        // POST: StudyRoutes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.StudyRoute == null)
            {
                return Problem("Entity set 'UserContext.StudyRoute'  is null.");
            }
            var studyRoute = await _context.StudyRoute.FindAsync(id);
            if (studyRoute != null)
            {
                _context.StudyRoute.Remove(studyRoute);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudyRouteExists(int id)
        {
          return (_context.StudyRoute?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
