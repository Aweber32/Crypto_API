using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CryptoApi.Migrations
{
    /// <inheritdoc />
    public partial class updatingcoindata1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "FearandGreed",
                table: "CoinDatas",
                type: "float",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FearandGreed",
                table: "CoinDatas");
        }
    }
}
