using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoApi.Migrations
{
    /// <inheritdoc />
    public partial class AddEngineeredFeaturesToTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.CreateTable(
                name: "FeatureEngineerings",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Predicted_Price_1h_Stable = table.Column<double>(type: "float", nullable: true),
                    SentimentScore = table.Column<double>(type: "float", nullable: true),
                    Price_Lag_1 = table.Column<double>(type: "float", nullable: true),
                    Price_Lag_2 = table.Column<double>(type: "float", nullable: true),
                    Volume24h_Lag_1 = table.Column<double>(type: "float", nullable: true),
                    Volume24h_Lag_2 = table.Column<double>(type: "float", nullable: true),
                    VolumeChange24h_Lag_1 = table.Column<double>(type: "float", nullable: true),
                    VolumeChange24h_Lag_2 = table.Column<double>(type: "float", nullable: true),
                    FearandGreed_Lag_1 = table.Column<double>(type: "float", nullable: true),
                    FearandGreed_Lag_2 = table.Column<double>(type: "float", nullable: true),
                    SentimentScore_Lag_1 = table.Column<double>(type: "float", nullable: true),
                    SentimentScore_Lag_2 = table.Column<double>(type: "float", nullable: true),
                    Price_Rolling_Mean_3h = table.Column<double>(type: "float", nullable: true),
                    Volume_Rolling_Std_6h = table.Column<double>(type: "float", nullable: true),
                    Sentiment_Rolling_Mean_3h = table.Column<double>(type: "float", nullable: true),
                    Price_Momentum_1h = table.Column<double>(type: "float", nullable: true),
                    Sentiment_Momentum_1h = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureEngineerings", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureEngineerings");

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Buy_Sell_Hold_Skip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Predicted_Price_1h = table.Column<double>(type: "float", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.id);
                });
        }
    }
}
