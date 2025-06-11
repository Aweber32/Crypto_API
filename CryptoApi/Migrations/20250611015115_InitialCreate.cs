using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoinDatas",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TokenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume24h = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VolumeChange24h = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentChange1h = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentChange24h = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentChange7d = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentChange30d = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentChange60d = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentChange90d = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinDatas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "InvestorGrades",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TokenName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingSignal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenTrend = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradingSignalsReturns = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HoldingReturns = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TMTraderGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TMInvestorGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TAGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuantGrade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TMTraderGrade24hPctChange = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestorGrades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sentiments",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PositiveReddit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NeutralReddit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NegativeReddit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCountReddit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sentiments", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoinDatas");

            migrationBuilder.DropTable(
                name: "InvestorGrades");

            migrationBuilder.DropTable(
                name: "Sentiments");
        }
    }
}
