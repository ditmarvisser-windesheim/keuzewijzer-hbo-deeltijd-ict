using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;

namespace keuzewijzer_hbo_deeltijd_ict_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyRouteController : ControllerBase
    {
        private readonly UserContext _context;

        public StudyRouteController(UserContext context)
        {
            _context = context;
        }

        // GET: api/StudyRoute
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudyRoute>>> GetStudyRoute()
        {
            if (_context.StudyRoutes == null)
            {
                return NotFound();
            }
            return await _context.StudyRoutes.ToListAsync();
        }

        // GET: api/StudyRoute/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudyRoute>> GetStudyRoute(int id)
        {
            if (_context.StudyRoutes == null)
            {
                return NotFound();
            }
            var @studyRoute = await _context.StudyRoutes.FindAsync(id);

            if (@studyRoute == null)
            {
                return NotFound();
            }

            return @studyRoute;
        }

        // PUT: api/StudyRoute/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudyRoute(int id, StudyRoute @studyRoute)
        {
            if (id != @studyRoute.Id)
            {
                return BadRequest();
            }

            _context.Entry(@studyRoute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudyRouteExists(id))
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

        // POST: api/StudyRoute
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudyRoute>> PostStudyRoute(StudyRoute @studyRoute)
        {
            if (_context.StudyRoutes == null)
            {
                return Problem("Entity set 'KeuzewijzerContext.StudyRoute'  is null.");
            }
            _context.StudyRoutes.Add(@studyRoute);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudyRoute", new { id = @studyRoute.Id }, @studyRoute);
        }

        // DELETE: api/StudyRoute/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudyRoute(int id)
        {
            if (_context.StudyRoutes == null)
            {
                return NotFound();
            }
            var @studyRoute = await _context.StudyRoutes.FindAsync(id);
            if (@studyRoute == null)
            {
                return NotFound();
            }

            _context.StudyRoutes.Remove(@studyRoute);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudyRouteExists(int id)
        {
            return (_context.StudyRoutes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
