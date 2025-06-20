using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CryptoApi.Data;
using CryptoApi.Models;

namespace CryptoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorGradeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public InvestorGradeController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/InvestorGrade
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvestorGrade>>> GetLatestInvestorGrades()
        {
            var grades = await _context.InvestorGrades
                .OrderByDescending(g => g.Date)
                .Take(24)
                .ToListAsync();

            return Ok(grades);
        }

        // POST: api/InvestorGrade
        [HttpPost]
        public async Task<ActionResult<InvestorGrade>> PostInvestorGrade(InvestorGrade investorGrade)
        {
            if (await _context.InvestorGrades.AnyAsync(g => g.id == investorGrade.id))
            {
                return Conflict("A record with this ID already exists.");
            }

            _context.InvestorGrades.Add(investorGrade);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLatestInvestorGrades), new { id = investorGrade.id }, investorGrade);
        }
        // POST: api/InvestorGrade/bulk
        [HttpPost("bulk")]
        public async Task<IActionResult> PostBulk([FromBody] List<InvestorGrade> grades)
        {
            if (grades == null || grades.Count == 0)
            {
                return BadRequest("No investor grade data provided.");
            }

            await _context.InvestorGrades.AddRangeAsync(grades);
            await _context.SaveChangesAsync();

            return Ok(new { inserted = grades.Count });
        }
    }
}
