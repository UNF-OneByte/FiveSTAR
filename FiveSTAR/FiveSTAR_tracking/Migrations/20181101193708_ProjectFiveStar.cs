using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveSTAR_tracking.Migrations
{
    public partial class ProjectFiveStar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectFiveStar",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectManager = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EstEndtDate = table.Column<DateTime>(nullable: false),
                    ActEndDate = table.Column<DateTime>(nullable: false),
                    EstCost = table.Column<decimal>(nullable: false),
                    ActCost = table.Column<decimal>(nullable: false),
                    EstHours = table.Column<decimal>(nullable: false),
                    ActHours = table.Column<decimal>(nullable: false),
                    IdUsers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFiveStar", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectFiveStar");
        }
    }
}
