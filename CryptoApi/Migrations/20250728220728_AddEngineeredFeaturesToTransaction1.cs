using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoApi.Migrations
{
    /// <inheritdoc />
    public partial class AddEngineeredFeaturesToTransaction1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BollingerBandBreakout",
                table: "FeatureEngineerings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "BollingerBandSqueeze",
                table: "FeatureEngineerings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MeanReversionLongSignal",
                table: "FeatureEngineerings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MeanReversionShortSignal",
                table: "FeatureEngineerings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MomentumConfirmed",
                table: "FeatureEngineerings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MomentumScore",
                table: "FeatureEngineerings",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "MultiFactorConfluenceSignal",
                table: "FeatureEngineerings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price_Deviation_Pct",
                table: "FeatureEngineerings",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Volume24h_Rolling_Mean_24h",
                table: "FeatureEngineerings",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "VolumeSpikeSignal",
                table: "FeatureEngineerings",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Volume_Spike_Ratio",
                table: "FeatureEngineerings",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BollingerBandBreakout",
                table: "FeatureEngineerings");

            migrationBuilder.DropColumn(
                name: "BollingerBandSqueeze",
                table: "FeatureEngineerings");

            migrationBuilder.DropColumn(
                name: "MeanReversionLongSignal",
                table: "FeatureEngineerings");

            migrationBuilder.DropColumn(
                name: "MeanReversionShortSignal",
                table: "FeatureEngineerings");

            migrationBuilder.DropColumn(
                name: "MomentumConfirmed",
                table: "FeatureEngineerings");

            migrationBuilder.DropColumn(
                name: "MomentumScore",
                table: "FeatureEngineerings");

            migrationBuilder.DropColumn(
                name: "MultiFactorConfluenceSignal",
                table: "FeatureEngineerings");

            migrationBuilder.DropColumn(
                name: "Price_Deviation_Pct",
                table: "FeatureEngineerings");

            migrationBuilder.DropColumn(
                name: "Volume24h_Rolling_Mean_24h",
                table: "FeatureEngineerings");

            migrationBuilder.DropColumn(
                name: "VolumeSpikeSignal",
                table: "FeatureEngineerings");

            migrationBuilder.DropColumn(
                name: "Volume_Spike_Ratio",
                table: "FeatureEngineerings");
        }
    }
}
