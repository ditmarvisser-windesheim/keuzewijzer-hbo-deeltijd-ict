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
    public class StudyRouteController : ControllerBase
    {
        private readonly KeuzewijzerContext _context;

        public StudyRouteController(KeuzewijzerContext context)
        {
            _context = context;
        }

        // GET: api/StudyRoute
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator,Studiebegeleider,Student")]
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<IEnumerable<StudyRouteItem>>> GetStudyRouteByUserId(string userId)
        {
            //1. get the studyroute with the correct userid
            var studyRoute = await _context.StudyRoutes.Where(c => c.UserId == userId).FirstOrDefaultAsync();
            //2. check if the studyRoute exists
            if (studyRoute == null) return NotFound();

            //3. if the studyRouteItems exists, get the modules from the cohort
            var studyRouteItems = await _context.StudyRouteItems
                .Where(m => m.StudyRouteId == studyRoute.Id)
                .ToListAsync();

            //4. check if there are any studyRouteItems
            if (studyRouteItems == null) return NotFound();

            //5. return the studyRouteItems including the cohort and the required modules

            return studyRouteItems;


            return NotFound();
        }

        // GET: api/StudyRoute
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator")]
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
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator,Studiebegeleider,Student")]
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
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator,Studiebegeleider,Student")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudyRoute(int id, StudyRoute @studyRoute)
        {

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
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator,Studiebegeleider,Student")]
        [HttpPost]
        public async Task<ActionResult<StudyRoute>> PostStudyRoute(StudyRoute studyRoute)
        {
            if (_context.StudyRoutes == null)
            {
                return Problem("Entity set 'KeuzewijzerContext.StudyRoute' is null.");
            }

            /*if (studyRoute.StudyRouteItems == null || studyRoute.StudyRouteItems.Count < 7)
            {
                return BadRequest("The 'Posts' collection must contain at least 7 items.");
            }*/

            var existingStudyRoute = await _context.StudyRoutes
                .Include(sr => sr.StudyRouteItems)
                .FirstOrDefaultAsync(sr => sr.UserId == studyRoute.UserId);

            if (existingStudyRoute != null)
            {
                // Update the existing study route with the new data
                _context.StudyRouteItems.RemoveRange(existingStudyRoute.StudyRouteItems);
                existingStudyRoute.StudyRouteItems = studyRoute.StudyRouteItems;
                existingStudyRoute.Send_sb = studyRoute.Send_sb;
                existingStudyRoute.Send_eb = studyRoute.Send_eb;
                existingStudyRoute.Approved_sb = studyRoute.Approved_sb;
                existingStudyRoute.Approved_eb= studyRoute.Approved_eb;
                existingStudyRoute.Note= studyRoute.Note;
            }
            else
            {
                // Add a new study route
                _context.StudyRoutes.Add(studyRoute);
            }

            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudyRoute", new { id = studyRoute.Id }, studyRoute);
        }


        // DELETE: api/StudyRoute/5
        [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme, Roles = "Administrator,Student")]
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
