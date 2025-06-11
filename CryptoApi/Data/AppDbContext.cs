using Microsoft.EntityFrameworkCore;
using CryptoApi.Models;

namespace CryptoApi.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<CoinData> CoinDatas { get; set; }
        public DbSet<InvestorGrade> InvestorGrades { get; set; }
        public DbSet<Sentiment> Sentiments { get; set; }
    }
    
}