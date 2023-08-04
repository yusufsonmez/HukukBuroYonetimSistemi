using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HukukBuroYonetimSistemi.Migrations
{
    /// <inheritdoc />
    public partial class MahkemelerWebViewsPlaceholderAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ValueForView",
                table: "MahkemelerWebViews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Placeholder",
                table: "MahkemelerWebViews",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Placeholder",
                table: "MahkemelerWebViews");

            migrationBuilder.AlterColumn<string>(
                name: "ValueForView",
                table: "MahkemelerWebViews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
