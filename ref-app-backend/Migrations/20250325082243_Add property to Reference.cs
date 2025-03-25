using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ref_app_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddpropertytoReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Publisher",
                table: "References",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Publisher",
                table: "References");
        }
    }
}
