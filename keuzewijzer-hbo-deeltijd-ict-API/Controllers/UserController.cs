using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using keuzewijzer_hbo_deeltijd_ict_API.Dal;
using keuzewijzer_hbo_deeltijd_ict_API.Models;


//EXAMPLE
namespace keuzewijzer_hbo_deeltijd_ict_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly KeuzewijzerContext _context;

        public UserController(KeuzewijzerContext context)
        {
            _context = context;
        }

        // GET: api/User
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            return await _context.Users.ToListAsync();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(string id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }

            var user = await _context.Users.Include(u => u.SemesterItems).FirstOrDefaultAsync(u => u.Id == id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(string id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            if (_context.Users == null)
            {
                return Problem("Entity set 'KeuzewijzerContext.Users'  is null.");
            }
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (_context.Users == null)
            {
                return NotFound();
            }
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpPut("UpdateSemesters/{id}")]
        public async Task<IActionResult> UpdateUserSemesters(string id, int[] semesterIds)
        {
            try
            {
                var user = await _context.Users.Where(u => u.Id == id).Include(u => u.SemesterItems).FirstOrDefaultAsync();
                if (user == null)
                {
                    return NotFound();
                }

                if (user.SemesterItems == null)
                {
                    user.SemesterItems = new List<SemesterItem>();
                }
                user.SemesterItems.Clear();
                // Save the changes to clear existing semester items
                await _context.SaveChangesAsync();

                // Get the semester items based on the provided IDs
                var semesterItems = await _context.SemesterItems.Where(si => semesterIds.Contains(si.Id)).ToListAsync();

                // Add the semester items to the user
                user.SemesterItems.AddRange(semesterItems);

                // Save the changes to update the user's semester items
                await _context.SaveChangesAsync();

                return Ok(user);
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (e.g., log the error, return an error response)
                return StatusCode(500, "An error occurred while updating user semesters.");
            }
        }


        private bool UserExists(string id)
        {
            return (_context.Users?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
