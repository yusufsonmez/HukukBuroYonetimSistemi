using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HukukBuroYonetimSistemi.Migrations
{
    /// <inheritdoc />
    public partial class ModelIsimDegisiklikleri : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MahkemeModel");

            migrationBuilder.DropTable(
                name: "GorevAtama");

            migrationBuilder.DropTable(
                name: "UserModel");

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
                    UserNameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevAtamalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GorevAtamalar_Users_UserNameId",
                        column: x => x.UserNameId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    GorevAtamaId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GorevAtamalar_UserNameId",
                table: "GorevAtamalar",
                column: "UserNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Mahkemeler_GorevAtamaId",
                table: "Mahkemeler",
                column: "GorevAtamaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mahkemeler");

            migrationBuilder.DropTable(
                name: "GorevAtamalar");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "UserModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GorevAtama",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserNameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevAtama", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GorevAtama_UserModel_UserNameId",
                        column: x => x.UserNameId,
                        principalTable: "UserModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MahkemeModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GorevAtamaId = table.Column<int>(type: "int", nullable: false),
                    Diger = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosyaNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurusmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GelenEvrakTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GelmeTarihi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gorev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HedefSureSonGun = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahkeme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TebligTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TebligTuru = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MahkemeModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MahkemeModel_GorevAtama_GorevAtamaId",
                        column: x => x.GorevAtamaId,
                        principalTable: "GorevAtama",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GorevAtama_UserNameId",
                table: "GorevAtama",
                column: "UserNameId");

            migrationBuilder.CreateIndex(
                name: "IX_MahkemeModel_GorevAtamaId",
                table: "MahkemeModel",
                column: "GorevAtamaId");
        }
    }
}
