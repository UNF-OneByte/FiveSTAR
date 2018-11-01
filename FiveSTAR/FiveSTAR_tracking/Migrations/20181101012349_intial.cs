using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FiveSTAR_tracking.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectTasks",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    TaskName = table.Column<string>(nullable: true),
                    Task_Est_Cost = table.Column<decimal>(nullable: false),
                    Task_Act_Cost = table.Column<decimal>(nullable: false),
                    idVendor = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    HoursWorked = table.Column<decimal>(nullable: false),
                    idUsers = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTasks", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectTasks");
        }
    }
}
