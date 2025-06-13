using System.ComponentModel.DataAnnotations;

namespace CryptoApi.Models
{
    public class Sentiment
    {
        [Key]
        public string id { get; set; }
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public double? PositiveReddit { get; set; }
        public double? NeutralReddit { get; set; }
        public double? NegativeReddit { get; set; }
        public int? PostCountReddit { get; set; }
    }
}