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
    [Route("api/Replies")]
    public class RepliesController : Controller
    {
        private readonly ReplieContext _context;

        public RepliesController(ReplieContext context)
        {
            _context = context;
        }

        // GET: api/Replies
        [HttpGet]
        public IEnumerable<Replie> GetReplies()
        {
            return _context.Replies.ToList();
        }

        // GET: api/Replies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReplie([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var replie = await _context.Replies.SingleOrDefaultAsync(m => m.id == id);

            if (replie == null)
            {
                return NotFound();
            }

            return Ok(replie);
        }

        // PUT: api/Replies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReplie([FromRoute] long id, [FromBody] Replie replie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != replie.id)
            {
                return BadRequest();
            }

            _context.Entry(replie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReplieExists(id))
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

        // POST: api/Replies
        [HttpPost]
        public async Task<IActionResult> PostReplie([FromBody] Replie replie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Replies.Add(replie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReplie", new { id = replie.id }, replie);
        }

        // DELETE: api/Replies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReplie([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var replie = await _context.Replies.SingleOrDefaultAsync(m => m.id == id);
            if (replie == null)
            {
                return NotFound();
            }

            _context.Replies.Remove(replie);
            await _context.SaveChangesAsync();

            return Ok(replie);
        }

        private bool ReplieExists(long id)
        {
            return _context.Replies.Any(e => e.id == id);
        }
    }
}