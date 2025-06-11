using System.ComponentModel.DataAnnotations;

namespace CryptoApi.Models
{
    public class CoinData
    {
        [Key]
        public string id { get; set; }
        public string Symbol { get; set; }
        public DateTime Date { get; set; } 
        public string? TokenName { get; set; }
        public string? Price { get; set; }
        public string? Volume24h { get; set; }
        public string? VolumeChange24h { get; set; }
        public string? PercentChange1h { get; set; }
        public string? PercentChange24h { get; set; }
        public string? PercentChange7d { get; set; }
        public string? PercentChange30d { get; set; }
        public string? PercentChange60d { get; set; }
        public string? PercentChange90d { get; set; }
    }
}