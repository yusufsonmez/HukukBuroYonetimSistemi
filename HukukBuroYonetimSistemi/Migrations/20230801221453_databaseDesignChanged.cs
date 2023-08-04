using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HukukBuroYonetimSistemi.Migrations
{
    /// <inheritdoc />
    public partial class databaseDesignChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mahkeme",
                table: "Mahkemeler",
                newName: "YargiTuru");

            migrationBuilder.AddColumn<string>(
                name: "YargiBirimi",
                table: "Mahkemeler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YargiBirimi",
                table: "Mahkemeler");

            migrationBuilder.RenameColumn(
                name: "YargiTuru",
                table: "Mahkemeler",
                newName: "Mahkeme");
        }
    }
}
