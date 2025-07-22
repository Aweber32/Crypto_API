using System.ComponentModel.DataAnnotations;

namespace CryptoApi.Models
{
    public class FeatureEngineering
    {
        [Key]
        public string id { get; set; }
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public double? Predicted_Price_1h_Stable { get; set; }

        // Feature-Engineered Columns
        public double? SentimentScore { get; set; }
        public double? Price_Lag_1 { get; set; }
        public double? Price_Lag_2 { get; set; }
        public double? Volume24h_Lag_1 { get; set; }
        public double? Volume24h_Lag_2 { get; set; }
        public double? VolumeChange24h_Lag_1 { get; set; }
        public double? VolumeChange24h_Lag_2 { get; set; }
        public double? FearandGreed_Lag_1 { get; set; }
        public double? FearandGreed_Lag_2 { get; set; }
        public double? SentimentScore_Lag_1 { get; set; }
        public double? SentimentScore_Lag_2 { get; set; }
        public double? Price_Rolling_Mean_3h { get; set; }
        public double? Volume_Rolling_Std_6h { get; set; }
        public double? Sentiment_Rolling_Mean_3h { get; set; }
        public double? Price_Momentum_1h { get; set; }
        public double? Sentiment_Momentum_1h { get; set; }

    }
}