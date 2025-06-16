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
        public double? Price { get; set; }
        public double? Volume24h { get; set; }
        public double? VolumeChange24h { get; set; }
        public double? PercentChange1h { get; set; }
        public double? PercentChange24h { get; set; }
        public double? PercentChange7d { get; set; }
        public double? PercentChange30d { get; set; }
        public double? PercentChange60d { get; set; }
        public double? PercentChange90d { get; set; }
    }
}