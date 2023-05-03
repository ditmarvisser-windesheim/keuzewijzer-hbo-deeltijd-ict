using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;

namespace keuzewijzer_hbo_deeltijd_ict_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudyRouteItemController : Controller
    {
        private readonly UserContext _context;

        public StudyRouteItemController(UserContext context)
        {
            _context = context;
        }

        // GET: api/StudyRouteItem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudyRouteItem>>> GetStudyRouteItem()
        {
            if (_context.StudyRouteItems == null)
            {
                return NotFound();
            }
            return await _context.StudyRouteItems.ToListAsync();
        }

        // GET: api/StudyRouteItem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudyRouteItem>> GetStudyRouteItem(int id)
        {
            if (_context.StudyRouteItems == null)
            {
                return NotFound();
            }
            var @studyRouteItem = await _context.StudyRouteItems.FindAsync(id);

            if (@studyRouteItem == null)
            {
                return NotFound();
            }

            return @studyRouteItem;
        }

        // PUT: api/StudyRouteItem/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudyRouteItem(int id, StudyRouteItem @studyRouteItem)
        {
            if (id != @studyRouteItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(@studyRouteItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudyRouteItemExists(id))
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

        // POST: api/StudyRouteItem
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StudyRouteItem>> PostStudyRouteItem(StudyRouteItem @studyRouteItem)
        {
            if (_context.StudyRouteItems == null)
            {
                return Problem("Entity set 'KeuzewijzerContext.StudyRouteItem'  is null.");
            }
            _context.StudyRouteItems.Add(@studyRouteItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudyRouteItem", new { id = @studyRouteItem.Id }, @studyRouteItem);
        }

        // DELETE: api/StudyRoute/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModule(int id)
        {
            if (_context.StudyRoutes == null)
            {
                return NotFound();
            }
            var @studyRouteItem = await _context.StudyRoutes.FindAsync(id);
            if (@studyRouteItem == null)
            {
                return NotFound();
            }

            _context.StudyRoutes.Remove(@studyRouteItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudyRouteItemExists(int id)
        {
            return (_context.StudyRoutes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
