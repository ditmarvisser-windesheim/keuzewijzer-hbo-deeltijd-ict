using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;
using Microsoft.AspNetCore.Authorization;

namespace keuzewijzer_hbo_deeltijd_ict_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CohortController : ControllerBase
    {
        private readonly KeuzewijzerContext _context;

        public CohortController(KeuzewijzerContext context)
        {
            _context = context;
        }

        // GET: api/cohort
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cohort>>> GetCohort()
        {
            if (_context.Cohorts == null)
            {
                return NotFound();
            }
            return await _context.Cohorts.ToListAsync();
        }

        // GET: api/cohort/5
        [Authorize(Roles = "Administrator")]
        [HttpGet("{id}")]
        public async Task<ActionResult<Cohort>> GetCohort(int id)
        {
            if (_context.Cohorts == null)
            {
                return NotFound();
            }
            var @cohort = await _context.Cohorts.FindAsync(id);

            if (@cohort == null)
            {
                return NotFound();
            }

            return @cohort;
        }

        // PUT: api/cohort/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCohort(int id, Cohort @cohort)
        {
            if (id != @cohort.Id)
            {
                return BadRequest();
            }

            _context.Entry(@cohort).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CohortExists(id))
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

        // POST: api/cohort
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<ActionResult<Cohort>> PostCohort(Cohort cohort)
        {
            if (_context.Cohorts == null)
            {
                return Problem("Entity set 'KeuzewijzerContext.Cohorts'  is null.");
            }
            _context.Cohorts.Add(cohort);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCohort", new { id = cohort.Id }, cohort);
        }

        // DELETE: api/cohort/5
        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCohort(int id)
        {
            if (_context.Cohorts == null)
            {
                return NotFound();
            }
            var @cohort = await _context.Cohorts.FindAsync(id);
            if (@cohort == null)
            {
                return NotFound();
            }

            _context.Cohorts.Remove(@cohort);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CohortExists(int id)
        {
            return (_context.Cohorts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
