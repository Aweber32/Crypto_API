using Microsoft.EntityFrameworkCore;

namespace CryptoApi.Models
{
    public class DatabaseContext : DbContext
    {
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<CoinData> CoinDatas { get; set; }
        public DbSet<InvestorGrade> InvestorGrades { get; set; }
        public DbSet<Sentiment> Sentiments { get; set; }
    }
    
}