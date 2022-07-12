using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using familyAPI.Data;

namespace familyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Odams1Controller : ControllerBase
    {
        private readonly FamilyDb _context;

        public Odams1Controller(FamilyDb context)
        {
            _context = context;
        }

        // GET: api/Odams1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Odam>>> GetOdam()
        {
          if (_context.Odam == null)
          {
              return NotFound();
          }
            return await _context.Odam.ToListAsync();
        }

        // GET: api/Odams1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Odam>> GetOdam(int? id)
        {
          if (_context.Odam == null)
          {
              return NotFound();
          }
            var odam = await _context.Odam.FindAsync(id);

            if (odam == null)
            {
                return NotFound();
            }

            return odam;
        }

        // PUT: api/Odams1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOdam(int? id, Odam odam)
        {
            if (id != odam.Id)
            {
                return BadRequest();
            }

            _context.Entry(odam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OdamExists(id))
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

        // POST: api/Odams1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Odam>> PostOdam(Odam odam)
        {
          if (_context.Odam == null)
          {
              return Problem("Entity set 'FamilyDb.Odam'  is null.");
          }
            _context.Odam.Add(odam);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOdam", new { id = odam.Id }, odam);
        }

        // DELETE: api/Odams1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOdam(int? id)
        {
            if (_context.Odam == null)
            {
                return NotFound();
            }
            var odam = await _context.Odam.FindAsync(id);
            if (odam == null)
            {
                return NotFound();
            }

            _context.Odam.Remove(odam);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OdamExists(int? id)
        {
            return (_context.Odam?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
