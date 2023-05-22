using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;

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
                //DIT GAAT NOG NIET HELEMAAL GOED
                .Include(m => m.RequiredSemesterItem) // Load the required modules
                .ToListAsync();

            //4. check if there are any modules
            if (semesterItems == null) return NotFound();

            //5. return the modules including the cohort and the required modules

            return semesterItems;


            return NotFound();
        }

        public ModuleController(KeuzewijzerContext context)
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
        public async Task<ActionResult<SemesterItem>> GetGetSemesterItems(int id)
        {
            if (_context.SemesterItems == null)
            {
                return NotFound();
            }
            var @semesterItems = await _context.SemesterItems.FindAsync(id);

            if (@semesterItems == null)
            {
                return NotFound();
            }

            return @semesterItems;
        }

        // PUT: api/SemesterItem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSemesterItem(int id, SemesterItems @semesterItems)
        {
            if (id != @semesterItems.Id)
            {
                return BadRequest();
            }

            _context.Entry(@semesterItems).State = EntityState.Modified;

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

            return NoContent();
        }

        // POST: api/SemesterItem
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SemesterItem>> PostSemesterItem(SemesterItem @semesterItems)
        {
            if (_context.SemesterItems == null)
            {
                return Problem("Entity set 'KeuzewijzerContext.Modules'  is null.");
            }
            _context.SemesterItems.Add(@semesterItems);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModule", new { id = @semesterItems.Id }, @semesterItems);
        }

        // DELETE: api/SemesterItem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModule(int id)
        {
            if (_context.SemesterItems == null)
            {
                return NotFound();
            }
            var @semesterItems = await _context.SemesterItems.FindAsync(id);
            if (@semesterItems == null)
            {
                return NotFound();
            }

            _context.SemesterItems.Remove(@semesterItems);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SemesterItemExists(int id)
        {
            return (_context.SemesterItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
