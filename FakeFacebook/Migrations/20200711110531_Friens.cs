using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeFacebook.Migrations
{
    public partial class Friens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Friend",
                table: "Account",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Friend",
                table: "Account");
        }
    }
}
