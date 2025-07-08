using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CryptoApi.Data;
using CryptoApi.Models;

namespace CryptoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TransactionController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Transaction
        // GET: api/Transaction?lookbackHours=INSERT HOURS HERE
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transaction>>> GetTransactions([FromQuery] int? lookbackHours)
        {
            var query = _context.Transactions.AsQueryable();

            var cutoff = DateTime.UtcNow.AddHours(-(lookbackHours ?? 24));
            query = query.Where(x => x.Date >= cutoff);

            var data = await query.ToListAsync();
            return Ok(data);
        }

        // POST: api/Transaction
        [HttpPost]
        public async Task<ActionResult<Transaction>> PostTransaction(Transaction transaction)
        {
            if (await _context.Transactions.AnyAsync(c => c.id == transaction.id))
            {
                return Conflict("A record with this ID already exists.");
            }

            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            return Ok(transaction);
        }
    }
}