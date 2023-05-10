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
    public class ModuleController : ControllerBase
    {
        private readonly KeuzewijzerContext _context;



        // Get the modules based on the cohort year
        [HttpGet("cohort/{cohortYear}")]
        public async Task<ActionResult<IEnumerable<Module>>> GetModulesByCohort(int cohortYear)
        {
            //1. get the cohort with the correct year
            var cohort = await _context.Cohorts.Where(c => c.Year == cohortYear).FirstOrDefaultAsync();
            //2. check if the cohort exists
            if (cohort == null) return NotFound();

            //3. if the cohort exists, get the modules from the cohort
            var modules = await _context.Modules
                .Where(m => m.Cohorts.Contains(cohort))
                //DIT GAAT NOG NIET HELEMAAL GOED
                .Include(m => m.RequiredModules) // Load the required modules
                .ToListAsync();

            //4. check if there are any modules
            if (modules == null) return NotFound();

            //5. return the modules including the cohort and the required modules

            return modules;


            return NotFound();
        }

        public ModuleController(KeuzewijzerContext context)
        {
            _context = context;
        }

        // GET: api/Module
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Module>>> GetModules()
        {
            if (_context.Modules == null)
            {
                return NotFound();
            }
            return await _context.Modules.ToListAsync();
        }

        // GET: api/Module/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Module>> GetModule(int id)
        {
            if (_context.Modules == null)
            {
                return NotFound();
            }
            var @module = await _context.Modules.FindAsync(id);

            if (@module == null)
            {
                return NotFound();
            }

            return @module;
        }

        // PUT: api/Module/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModule(int id, Module @module)
        {
            if (id != @module.Id)
            {
                return BadRequest();
            }

            _context.Entry(@module).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModuleExists(id))
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

        // POST: api/Module
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Module>> PostModule(Module @module)
        {
            if (_context.Modules == null)
            {
                return Problem("Entity set 'KeuzewijzerContext.Modules'  is null.");
            }
            _context.Modules.Add(@module);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModule", new { id = @module.Id }, @module);
        }

        // DELETE: api/Module/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModule(int id)
        {
            if (_context.Modules == null)
            {
                return NotFound();
            }
            var @module = await _context.Modules.FindAsync(id);
            if (@module == null)
            {
                return NotFound();
            }

            _context.Modules.Remove(@module);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ModuleExists(int id)
        {
            return (_context.Modules?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
