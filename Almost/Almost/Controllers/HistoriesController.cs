using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Almost.Model_Context;
using Almost.Models;

namespace Almost.Controllers
{
    [Produces("application/json")]
    [Route("api/Histories")]
    public class HistoriesController : Controller
    {
        private readonly HistoryContext _context;

        public HistoriesController(HistoryContext context)
        {
            _context = context;
        }

        // GET: api/Histories
        [HttpGet]
        public IEnumerable<History> GetHistory()
        {
            return _context.History.ToList();
        }

        // GET: api/Histories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHistory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var history = await _context.History.SingleOrDefaultAsync(m => m.id == id);

            if (history == null)
            {
                return NotFound();
            }

            return Ok(history);
        }

        // PUT: api/Histories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistory([FromRoute] int id, [FromBody] History history)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != history.id)
            {
                return BadRequest();
            }

            _context.Entry(history).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoryExists(id))
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

        // POST: api/Histories
        [HttpPost]
        public async Task<IActionResult> PostHistory([FromBody] History history)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.History.Add(history);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistory", new { id = history.id }, history);
        }

        // DELETE: api/Histories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistory([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var history = await _context.History.SingleOrDefaultAsync(m => m.id == id);
            if (history == null)
            {
                return NotFound();
            }

            _context.History.Remove(history);
            await _context.SaveChangesAsync();

            return Ok(history);
        }

        private bool HistoryExists(int id)
        {
            return _context.History.Any(e => e.id == id);
        }
    }
}