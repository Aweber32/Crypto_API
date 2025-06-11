using System.ComponentModel.DataAnnotations;

namespace CryptoApi.Models
{
    public class Sentiment
    {
        [Key]
        public string id { get; set; } = null!;
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public string? PositiveReddit { get; set; }
        public string? NeutralReddit { get; set; }
        public string? NegativeReddit { get; set; }
        public string? PostCountReddit { get; set; }
    }
}