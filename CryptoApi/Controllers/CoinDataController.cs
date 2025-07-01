using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CryptoApi.Data;
using CryptoApi.Models;

namespace CryptoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoinDataController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CoinDataController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CoinData
        // GET: api/CoinData?lookbackHours=INSERT HOURS HERE
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoinData>>> GetCoinData([FromQuery] int? lookbackHours)
        {
            var query = _context.CoinDatas.AsQueryable();

            var cutoff = DateTime.UtcNow.AddHours(-(lookbackHours ?? 24));
            query = query.Where(x => x.Date >= cutoff);

            var data = await query.ToListAsync();
            return Ok(data);
        }

        // POST: api/CoinData
        [HttpPost]
        public async Task<ActionResult<CoinData>> PostCoinData(CoinData coinData)
        {
            if (await _context.CoinDatas.AnyAsync(c => c.id == coinData.id))
            {
                return Conflict("A record with this ID already exists.");
            }

            _context.CoinDatas.Add(coinData);
            await _context.SaveChangesAsync();

            return Ok(coinData);
        }
        [HttpPost("bulk")]
        public async Task<IActionResult> PostBulk([FromBody] List<CoinData> coins)
        {
            if (coins == null || coins.Count == 0)
            {
                return BadRequest("No coin data provided.");
            }

            await _context.CoinDatas.AddRangeAsync(coins);
            await _context.SaveChangesAsync();

            return Ok(new { inserted = coins.Count });
        }
    }
}
