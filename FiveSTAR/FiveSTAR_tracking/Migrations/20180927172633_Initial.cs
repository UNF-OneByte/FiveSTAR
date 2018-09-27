using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveSTAR_tracking.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Task = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Hours = table.Column<decimal>(nullable: false),
                    MaterialCost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
