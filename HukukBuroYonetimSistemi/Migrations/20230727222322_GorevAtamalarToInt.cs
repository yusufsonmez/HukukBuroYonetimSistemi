using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HukukBuroYonetimSistemi.Migrations
{
    /// <inheritdoc />
    public partial class GorevAtamalarToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GorevAtamalar_MahkemeId",
                table: "GorevAtamalar");

            migrationBuilder.AddColumn<int>(
                name: "GorevAtamalar",
                table: "Mahkemeler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GorevAtamalar_MahkemeId",
                table: "GorevAtamalar",
                column: "MahkemeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GorevAtamalar_MahkemeId",
                table: "GorevAtamalar");

            migrationBuilder.DropColumn(
                name: "GorevAtamalar",
                table: "Mahkemeler");

            migrationBuilder.CreateIndex(
                name: "IX_GorevAtamalar_MahkemeId",
                table: "GorevAtamalar",
                column: "MahkemeId",
                unique: true);
        }
    }
}
