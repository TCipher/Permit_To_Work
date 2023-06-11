using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PermitToWorkSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddedSiteCheckerModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "siteCheckList",
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
                    GasTesting = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siteCheckList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "gasTestingResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LEL = table.Column<double>(type: "float", nullable: false),
                    O2 = table.Column<double>(type: "float", nullable: false),
                    H2S = table.Column<double>(type: "float", nullable: false),
                    CO = table.Column<double>(type: "float", nullable: false),
                    Others = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstrumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GasTesterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteCheckListId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gasTestingResult", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gasTestingResult_siteCheckList_SiteCheckListId",
                        column: x => x.SiteCheckListId,
                        principalTable: "siteCheckList",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_gasTestingResult_SiteCheckListId",
                table: "gasTestingResult",
                column: "SiteCheckListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gasTestingResult");

            migrationBuilder.DropTable(
                name: "siteCheckList");
        }
    }
}
