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
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoinData>>> GetLatestCoinData()
        {
            var data = await _context.CoinDatas
                .OrderByDescending(c => c.Date)
                .Take(24)
                .ToListAsync();

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

            return CreatedAtAction(nameof(GetLatestCoinData), new { id = coinData.id }, coinData);
        }
    }
}
