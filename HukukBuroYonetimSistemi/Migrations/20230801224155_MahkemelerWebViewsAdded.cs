using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HukukBuroYonetimSistemi.Migrations
{
    /// <inheritdoc />
    public partial class MahkemelerWebViewsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MahkemelerWebViews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForForView = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LabelForView = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdForView = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameForView = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueForView = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MahkemelerWebViews", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MahkemelerWebViews");
        }
    }
}
