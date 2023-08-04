using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HukukBuroYonetimSistemi.Migrations
{
    /// <inheritdoc />
    public partial class ValuesForMahkemeWebWiewsAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ValuesForMahkemeVewViewsId",
                table: "MahkemelerWebViews",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ValuesForMahkemeVewViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValuesForMahkemeVewViews", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MahkemelerWebViews_ValuesForMahkemeVewViewsId",
                table: "MahkemelerWebViews",
                column: "ValuesForMahkemeVewViewsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MahkemelerWebViews_ValuesForMahkemeVewViews_ValuesForMahkemeVewViewsId",
                table: "MahkemelerWebViews",
                column: "ValuesForMahkemeVewViewsId",
                principalTable: "ValuesForMahkemeVewViews",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MahkemelerWebViews_ValuesForMahkemeVewViews_ValuesForMahkemeVewViewsId",
                table: "MahkemelerWebViews");

            migrationBuilder.DropTable(
                name: "ValuesForMahkemeVewViews");

            migrationBuilder.DropIndex(
                name: "IX_MahkemelerWebViews_ValuesForMahkemeVewViewsId",
                table: "MahkemelerWebViews");

            migrationBuilder.DropColumn(
                name: "ValuesForMahkemeVewViewsId",
                table: "MahkemelerWebViews");
        }
    }
}
