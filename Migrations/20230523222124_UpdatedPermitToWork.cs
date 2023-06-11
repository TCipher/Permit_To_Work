using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PermitToWorkSystem.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPermitToWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DescriptionOfWork",
                table: "permitToWorkForm",
                newName: "Duration_Of_Work");

            migrationBuilder.AddColumn<string>(
                name: "Description_Of_Work",
                table: "permitToWorkForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description_Of_Work",
                table: "permitToWorkForm");

            migrationBuilder.RenameColumn(
                name: "Duration_Of_Work",
                table: "permitToWorkForm",
                newName: "DescriptionOfWork");
        }
    }
}
