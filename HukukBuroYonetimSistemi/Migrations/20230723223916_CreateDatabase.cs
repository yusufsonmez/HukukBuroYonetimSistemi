using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HukukBuroYonetimSistemi.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GorevAtamalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GorevAtamaId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevAtamalar", x => x.Id);
                });

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
                    GorevAtamaId = table.Column<int>(type: "int", nullable: true),
                    DurusmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahkemeler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mahkemeler_GorevAtamalar_GorevAtamaId",
                        column: x => x.GorevAtamaId,
                        principalTable: "GorevAtamalar",
                        principalColumn: "Id");
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    GorevAtamaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_GorevAtamalar_GorevAtamaId",
                        column: x => x.GorevAtamaId,
                        principalTable: "GorevAtamalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GorevAtamalar_UserId",
                table: "GorevAtamalar",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Mahkemeler_GorevAtamaId",
                table: "Mahkemeler",
                column: "GorevAtamaId",
                unique: true,
                filter: "[GorevAtamaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_GorevAtamaId",
                table: "Users",
                column: "GorevAtamaId");

            migrationBuilder.AddForeignKey(
                name: "FK_GorevAtamalar_Users_UserId",
                table: "GorevAtamalar",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GorevAtamalar_Users_UserId",
                table: "GorevAtamalar");

            migrationBuilder.DropTable(
                name: "Mahkemeler");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GorevAtamalar");
        }
    }
}
