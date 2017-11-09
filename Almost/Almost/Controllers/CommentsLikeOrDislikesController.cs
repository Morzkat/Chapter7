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
    [Route("api/CommentsLikeOrDislikes")]
    public class CommentsLikeOrDislikesController : Controller
    {
        private readonly CommentLikeOrDislikeContext _context;

        public CommentsLikeOrDislikesController(CommentLikeOrDislikeContext context)
        {
            _context = context;
        }

        // GET: api/CommentsLikeOrDislikes
        [HttpGet]
        public IEnumerable<CommentsLikeOrDislike> GetCommentLikeOrDislike()
        {
            return _context.CommentLikeOrDislike.ToList();
        }

        // GET: api/CommentsLikeOrDislikes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentsLikeOrDislike([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commentsLikeOrDislike = await _context.CommentLikeOrDislike.SingleOrDefaultAsync(m => m.id == id);

            if (commentsLikeOrDislike == null)
            {
                return NotFound();
            }

            return Ok(commentsLikeOrDislike);
        }

        // PUT: api/CommentsLikeOrDislikes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommentsLikeOrDislike([FromRoute] long id, [FromBody] CommentsLikeOrDislike commentsLikeOrDislike)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != commentsLikeOrDislike.id)
            {
                return BadRequest();
            }

            _context.Entry(commentsLikeOrDislike).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentsLikeOrDislikeExists(id))
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

        // POST: api/CommentsLikeOrDislikes
        [HttpPost]
        public async Task<IActionResult> PostCommentsLikeOrDislike([FromBody] CommentsLikeOrDislike commentsLikeOrDislike)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.CommentLikeOrDislike.Add(commentsLikeOrDislike);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommentsLikeOrDislike", new { id = commentsLikeOrDislike.id }, commentsLikeOrDislike);
        }

        // DELETE: api/CommentsLikeOrDislikes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommentsLikeOrDislike([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var commentsLikeOrDislike = await _context.CommentLikeOrDislike.SingleOrDefaultAsync(m => m.id == id);
            if (commentsLikeOrDislike == null)
            {
                return NotFound();
            }

            _context.CommentLikeOrDislike.Remove(commentsLikeOrDislike);
            await _context.SaveChangesAsync();

            return Ok(commentsLikeOrDislike);
        }

        private bool CommentsLikeOrDislikeExists(long id)
        {
            return _context.CommentLikeOrDislike.Any(e => e.id == id);
        }
    }
}