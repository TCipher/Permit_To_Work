using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PermitToWorkSystem.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "permitToWorkForm",
                columns: table => new
                {
                    PermitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JSANO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration_Of_Work = table.Column<int>(type: "int", nullable: false),
                    Type_Of_Work = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Equipment_To_Be_Used = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Equipment_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Accent = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permitToWorkForm", x => x.PermitID);
                });

            migrationBuilder.CreateTable(
                name: "siteChecker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isolation = table.Column<bool>(type: "bit", nullable: false),
                    Bypass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MOC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Access = table.Column<bool>(type: "bit", nullable: false),
                    Barricade = table.Column<bool>(type: "bit", nullable: false),
                    CriticalLift = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NightWork = table.Column<bool>(type: "bit", nullable: false),
                    JSA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialRequirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GasTesting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LEL = table.Column<double>(type: "float", nullable: false),
                    O2 = table.Column<double>(type: "float", nullable: false),
                    H2S = table.Column<double>(type: "float", nullable: false),
                    CO = table.Column<double>(type: "float", nullable: false),
                    Others = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstrumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GasTesterName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteChecker", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "permitToWorkForm");

            migrationBuilder.DropTable(
                name: "siteChecker");
        }
    }
}
