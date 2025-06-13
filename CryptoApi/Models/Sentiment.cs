using System.ComponentModel.DataAnnotations;

namespace CryptoApi.Models
{
    public class Sentiment
    {
        [Key]
        public string id { get; set; }
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public decimal? PositiveReddit { get; set; }
        public decimal? NeutralReddit { get; set; }
        public decimal? NegativeReddit { get; set; }
        public int? PostCountReddit { get; set; }
    }
}