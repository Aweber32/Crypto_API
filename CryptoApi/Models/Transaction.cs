using System.ComponentModel.DataAnnotations;

namespace CryptoApi.Models
{
    public class Transaction
    {
        [Key]
        public string id { get; set; }
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public double? Price { get; set; }
        public double? Predicted_Price_1h { get; set; }
        public string? Buy_Sell_Hold_Skip { get; set; }
    }
}