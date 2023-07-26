using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HukukBuroYonetimSistemi.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesAndRealationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mahkemeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mahkeme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosyaNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GelenEvrakTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TebligTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TebligTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diger = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GelmeTarihi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HedefSureSonGun = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gorev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DurusmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahkemeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GorevAtamalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MahkemeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevAtamalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GorevAtamalar_Mahkemeler_MahkemeId",
                        column: x => x.MahkemeId,
                        principalTable: "Mahkemeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GorevAtamalar_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GorevAtamalar_MahkemeId",
                table: "GorevAtamalar",
                column: "MahkemeId");

            migrationBuilder.CreateIndex(
                name: "IX_GorevAtamalar_UserId",
                table: "GorevAtamalar",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GorevAtamalar");

            migrationBuilder.DropTable(
                name: "Mahkemeler");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
