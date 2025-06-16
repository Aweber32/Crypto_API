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
        public int? TradingSignal { get; set; } 
        public int? TokenTrend { get; set; } 
        public double? TradingSignalsReturns { get; set; }
        public double? HoldingReturns { get; set; }
        public double? TMTraderGrade { get; set; }
        public int? TMInvestorGrade { get; set; }
        public double? TAGrade { get; set; }
        public double? QuantGrade { get; set; }
        public double? TMTraderGrade24hPctChange { get; set; }
    }
}