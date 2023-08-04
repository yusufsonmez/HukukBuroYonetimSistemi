using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HukukBuroYonetimSistemi.Migrations
{
    /// <inheritdoc />
    public partial class ValuesForMahkemeWebWiewsRelationIdAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MahkemelerWebViews_ValuesForMahkemeVewViews_ValuesForMahkemeVewViewsId",
                table: "MahkemelerWebViews");

            migrationBuilder.RenameColumn(
                name: "ValuesForMahkemeVewViewsId",
                table: "MahkemelerWebViews",
                newName: "ValuesForMahkemeWebViewsId");

            migrationBuilder.RenameIndex(
                name: "IX_MahkemelerWebViews_ValuesForMahkemeVewViewsId",
                table: "MahkemelerWebViews",
                newName: "IX_MahkemelerWebViews_ValuesForMahkemeWebViewsId");

            migrationBuilder.AddColumn<int>(
                name: "RelationId",
                table: "ValuesForMahkemeVewViews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MahkemelerWebViews_ValuesForMahkemeVewViews_ValuesForMahkemeWebViewsId",
                table: "MahkemelerWebViews",
                column: "ValuesForMahkemeWebViewsId",
                principalTable: "ValuesForMahkemeVewViews",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MahkemelerWebViews_ValuesForMahkemeVewViews_ValuesForMahkemeWebViewsId",
                table: "MahkemelerWebViews");

            migrationBuilder.DropColumn(
                name: "RelationId",
                table: "ValuesForMahkemeVewViews");

            migrationBuilder.RenameColumn(
                name: "ValuesForMahkemeWebViewsId",
                table: "MahkemelerWebViews",
                newName: "ValuesForMahkemeVewViewsId");

            migrationBuilder.RenameIndex(
                name: "IX_MahkemelerWebViews_ValuesForMahkemeWebViewsId",
                table: "MahkemelerWebViews",
                newName: "IX_MahkemelerWebViews_ValuesForMahkemeVewViewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MahkemelerWebViews_ValuesForMahkemeVewViews_ValuesForMahkemeVewViewsId",
                table: "MahkemelerWebViews",
                column: "ValuesForMahkemeVewViewsId",
                principalTable: "ValuesForMahkemeVewViews",
                principalColumn: "Id");
        }
    }
}
