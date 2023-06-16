using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace keuzewijzer_hbo_deeltijd_ict_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterItemController : ControllerBase
    {
        private readonly KeuzewijzerContext _context;

        // Get the modules based on the cohort year
        [HttpGet("cohort/{cohortYear}")]
        public async Task<ActionResult<IEnumerable<SemesterItem>>> GetSemesterItemsByCohort(int cohortYear)
        {
            //1. get the cohort with the correct year
            var cohort = await _context.Cohorts.Where(c => c.Year == cohortYear).FirstOrDefaultAsync();
            //2. check if the cohort exists
            if (cohort == null) return NotFound();

            //3. if the cohort exists, get the modules from the cohort
            var semesterItems = await _context.SemesterItems
                .Where(m => m.Cohorts.Contains(cohort))
                .Include(m => m.RequiredSemesterItem) // Load the required modules
                .ToListAsync();

            //4. check if there are any modules
            if (semesterItems == null) return NotFound();

            //5. return the modules including the cohort and the required modules

            return semesterItems;
        }

        public SemesterItemController(KeuzewijzerContext context)
        {
            _context = context;
        }

        // GET: api/SemesterItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SemesterItem>>> GetSemesterItems()
        {
            if (_context.SemesterItems == null)
            {
                return NotFound();
            }
            return await _context.SemesterItems.ToListAsync();
        }

        // GET: api/SemesterItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SemesterItem>> GetSemesterItems(int id)
        {
            if (_context.SemesterItems == null)
            {
                return NotFound();
            }
            var semesterItem = await _context.SemesterItems
                .Include(m => m.RequiredSemesterItem)
                .Include(m => m.Cohorts)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (semesterItem == null)
            {
                return NotFound();
            }

            return semesterItem;
        }
        // PUT: api/SemesterItem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Moduleverantwoordelijke")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSemesterItem(int id, SemesterItem semesterItem)
        {
            if (id != semesterItem.Id)
            {
                return BadRequest();
            }

            // Get the existing semester item from the database
            var existingSemesterItem = await _context.SemesterItems
                .Include(si => si.Cohorts)
                .Include(si => si.RequiredSemesterItem)
                .FirstOrDefaultAsync(si => si.Id == id);

            if (existingSemesterItem == null)
            {
                return NotFound();
            }

            // Clear the cohorts and required semester items
            existingSemesterItem.Cohorts.Clear();
            existingSemesterItem.RequiredSemesterItem.Clear();

            // Detach the existing semester item from the context
            _context.Entry(existingSemesterItem).State = EntityState.Detached;

            // Update the modified semester item
            _context.Entry(semesterItem).State = EntityState.Modified;

            // If CohortsId is provided in the request, fetch the corresponding cohorts
            if (semesterItem.CohortsId != null)
            {
                semesterItem.Cohorts = await _context.Cohorts.Where(c => semesterItem.CohortsId.Contains(c.Id)).ToListAsync();
            }

            // If RequiredSemesterItemId is provided in the request, fetch the corresponding SemesterItems
            if (semesterItem.RequiredSemesterItemId != null)
            {
                semesterItem.RequiredSemesterItem = await _context.SemesterItems.Where(c => semesterItem.RequiredSemesterItemId.Contains(c.Id)).ToListAsync();
            }

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SemesterItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSemesterItems", new { id = semesterItem.Id }, semesterItem);
        }


        // POST: api/SemesterItem
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Moduleverantwoordelijke")]
        [HttpPost]
        public async Task<ActionResult<SemesterItem>> PostSemesterItem(SemesterItem semesterItem)
        {
            if (_context.SemesterItems == null)
            {
                return Problem("Entity set 'KeuzewijzerContext.Modules' is null.");
            }

            // If CohortsId is provided in the request, fetch the corresponding cohorts
            if (semesterItem.CohortsId != null)
            {
                semesterItem.Cohorts = await _context.Cohorts.Where(c => semesterItem.CohortsId.Contains(c.Id)).ToListAsync();
            }

            // If RequiredSemesterItemId is provided in the request, fetch he corresopndign SemestItems
            if (semesterItem.RequiredSemesterItemId != null)
            {
                semesterItem.RequiredSemesterItem = await _context.SemesterItems.Where(c => semesterItem.RequiredSemesterItemId.Contains(c.Id)).ToListAsync();
            }

            _context.SemesterItems.Add(semesterItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSemesterItems", new { id = semesterItem.Id }, semesterItem);
        }

        // DELETE: api/SemesterItem/5
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Moduleverantwoordelijke")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModule(int id)
        {
            var semesterItem = await _context.SemesterItems
                .Include(si => si.Cohorts)
                .Include(si => si.RequiredSemesterItem)
                .Include(si => si.DependentSemesterItem)
                .FirstOrDefaultAsync(si => si.Id == id);

            if (semesterItem == null)
            {
                return NotFound();
            }

            // Clear the cohorts and required semester items
            semesterItem.Cohorts.Clear();
            semesterItem.RequiredSemesterItem.Clear();
            semesterItem.DependentSemesterItem.Clear();

            // Detach the existing semester item from the context
            _context.Entry(semesterItem).State = EntityState.Detached;

            // Delete the semester item
            _context.SemesterItems.Remove(semesterItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool SemesterItemExists(int id)
        {
            return (_context.SemesterItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
