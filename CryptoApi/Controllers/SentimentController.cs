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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sentiment>>> GetLatestSentiments()
        {
            var sentiments = await _context.Sentiments
                .OrderByDescending(s => s.Date)
                .Take(24)
                .ToListAsync();

            return Ok(sentiments);
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

            return CreatedAtAction(nameof(GetLatestSentiments), new { id = sentiment.id }, sentiment);
        }
    }
}
