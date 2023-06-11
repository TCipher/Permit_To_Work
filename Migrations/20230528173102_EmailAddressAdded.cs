using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PermitToWorkSystem.Migrations
{
    /// <inheritdoc />
    public partial class EmailAddressAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "permitToWorkForm",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "permitToWorkForm");
        }
    }
}
