using System.ComponentModel.DataAnnotations;

namespace CryptoApi.Models
{
    public class InvestorGrade
    {
        [Key]
        public string id { get; set; }
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public string? TokenName { get; set; } 
        public string? TradingSignal { get; set; } 
        public string? TokenTrend { get; set; } 
        public decimal? TradingSignalsReturns { get; set; }
        public decimal? HoldingReturns { get; set; }
        public string? TMTraderGrade { get; set; }
        public string? TMInvestorGrade { get; set; }
        public string? TAGrade { get; set; }
        public string? QuantGrade { get; set; }
        public decimal? TMTraderGrade24hPctChange { get; set; }
    }
}