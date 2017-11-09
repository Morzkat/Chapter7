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
    [Route("api/HistoryLikeOrDislikes")]
    public class HistoryLikeOrDislikesController : Controller
    {
        private readonly HistoryLikeOrDislikeContext _context;

        public HistoryLikeOrDislikesController(HistoryLikeOrDislikeContext context)
        {
            _context = context;
        }

        // GET: api/HistoryLikeOrDislikes
        [HttpGet]
        public IEnumerable<HistoryLikeOrDislike> GetHistoryLikeOrDislike()
        {
            return _context.HistoryLikeOrDislike.ToList();
        }

        // GET: api/HistoryLikeOrDislikes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHistoryLikeOrDislike([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var historyLikeOrDislike = await _context.HistoryLikeOrDislike.SingleOrDefaultAsync(m => m.id == id);

            if (historyLikeOrDislike == null)
            {
                return NotFound();
            }

            return Ok(historyLikeOrDislike);
        }

        // PUT: api/HistoryLikeOrDislikes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistoryLikeOrDislike([FromRoute] long id, [FromBody] HistoryLikeOrDislike historyLikeOrDislike)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != historyLikeOrDislike.id)
            {
                return BadRequest();
            }

            _context.Entry(historyLikeOrDislike).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoryLikeOrDislikeExists(id))
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

        // POST: api/HistoryLikeOrDislikes
        [HttpPost]
        public async Task<IActionResult> PostHistoryLikeOrDislike([FromBody] HistoryLikeOrDislike historyLikeOrDislike)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.HistoryLikeOrDislike.Add(historyLikeOrDislike);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistoryLikeOrDislike", new { id = historyLikeOrDislike.id }, historyLikeOrDislike);
        }

        // DELETE: api/HistoryLikeOrDislikes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistoryLikeOrDislike([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var historyLikeOrDislike = await _context.HistoryLikeOrDislike.SingleOrDefaultAsync(m => m.id == id);
            if (historyLikeOrDislike == null)
            {
                return NotFound();
            }

            _context.HistoryLikeOrDislike.Remove(historyLikeOrDislike);
            await _context.SaveChangesAsync();

            return Ok(historyLikeOrDislike);
        }

        private bool HistoryLikeOrDislikeExists(long id)
        {
            return _context.HistoryLikeOrDislike.Any(e => e.id == id);
        }
    }
}