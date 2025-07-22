using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CryptoApi.Data;
using CryptoApi.Models;

namespace CryptoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureEngineeringController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FeatureEngineeringController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/FeatureEngineering
        // GET: api/FeatureEngineering?lookbackHours={insert here}
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FeatureEngineering>>> GetTransactions([FromQuery] int? lookbackHours)
        {
            var query = _context.FeatureEngineerings.AsQueryable();

            var cutoff = DateTime.UtcNow.AddHours(-(lookbackHours ?? 4380));
            query = query.Where(x => x.Date >= cutoff);

            var data = await query.ToListAsync();
            return Ok(data);
        }

        // POST: api/Transaction
        [HttpPost]
        public async Task<ActionResult<FeatureEngineering>> PostTransaction(FeatureEngineering featureEngineering)
        {
            if (await _context.FeatureEngineerings.AnyAsync(c => c.id == featureEngineering.id))
            {
                return Conflict("A record with this ID already exists.");
            }

            _context.FeatureEngineerings.Add(featureEngineering);
            await _context.SaveChangesAsync();

            return Ok(featureEngineering);
        }
    }
}