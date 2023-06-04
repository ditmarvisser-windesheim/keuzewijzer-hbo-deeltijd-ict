using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;

namespace keuzewijzer_hbo_deeltijd_ict_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly KeuzewijzerContext _context;

        public RoleController(KeuzewijzerContext context)
        {
            _context = context;
        }
        /*
        // GET: api/role
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Role>>> GetRole()
        {
          if (_context.Roles == null)
          {
              return NotFound();
          }
            return await _context.Roles.ToListAsync();
        }

        // GET: api/role/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Role>> GetRole(int id)
        {
          if (_context.Roles == null)
          {
              return NotFound();
          }
            var @role = await _context.Roles.FindAsync(id);

            if (@role == null)
            {
                return NotFound();
            }

            return @role;
        }

        // PUT: api/role/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRole(int id, Role @role)
        {
            if (id != @role.Id)
            {
                return BadRequest();
            }

            _context.Entry(@role).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoleExists(id))
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

        // POST: api/role
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Role>> PostRole(Role @role)
        {
          if (_context.Roles == null)
          {
              return Problem("Entity set 'KeuzewijzerContext.Roles'  is null.");
          }
            _context.Roles.Add(@role);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModule", new { id = @role.Id }, @role);
        }

        // DELETE: api/role/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            if (_context.Roles == null)
            {
                return NotFound();
            }
            var @role = await _context.Roles.FindAsync(id);
            if (@role == null)
            {
                return NotFound();
            }

            _context.Roles.Remove(@role);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoleExists(int id)
        {
            return (_context.Roles?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
        */
    }
}
