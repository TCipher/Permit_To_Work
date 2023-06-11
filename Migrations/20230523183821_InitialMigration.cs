using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PermitToWorkSystem.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "permitToWorkForm",
                columns: table => new
                {
                    PermitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Project = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationOfWork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permit_Applicant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JSA_NO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionOfWork = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Tools_Equipmet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permitToWorkForm", x => x.PermitID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "permitToWorkForm");
        }
    }
}
