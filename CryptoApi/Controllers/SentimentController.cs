using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CryptoApi.Data;
using CryptoApi.Models;

namespace CryptoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SentimentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SentimentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Sentiment
        // GET: api/Sentiment?lookbackHours=INSERT HOURS HERE
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sentiment>>> GetSentiments([FromQuery] int? lookbackHours)
        {
            var query = _context.Sentiments.AsQueryable();

            var cutoff = DateTime.UtcNow.AddHours(-(lookbackHours ?? 24));
            query = query.Where(x => x.Date >= cutoff);

            var data = await query.ToListAsync();
            return Ok(data);
        }

        // POST: api/Sentiment
        [HttpPost]
        public async Task<ActionResult<Sentiment>> PostSentiment(Sentiment sentiment)
        {
            if (await _context.Sentiments.AnyAsync(s => s.id == sentiment.id))
            {
                return Conflict("A record with this ID already exists.");
            }

            _context.Sentiments.Add(sentiment);
            await _context.SaveChangesAsync();

            return Ok(sentiment);
        }
        // POST: api/Sentiment/bulk
        [HttpPost("bulk")]
        public async Task<IActionResult> PostBulk([FromBody] List<Sentiment> sentiments)
        {
            if (sentiments == null || sentiments.Count == 0)
            {
                return BadRequest("No sentiment data provided.");
            }

            await _context.Sentiments.AddRangeAsync(sentiments);
            await _context.SaveChangesAsync();

            return Ok(new { inserted = sentiments.Count });
        }
    }
}
