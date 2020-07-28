using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeFacebook.Migrations
{
    public partial class Friends2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Friend",
                table: "Account");

            migrationBuilder.AddColumn<int>(
                name: "Friends",
                table: "Account",
                nullable: true,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Friends",
                table: "Account");

            migrationBuilder.AddColumn<string>(
                name: "Friend",
                table: "Account",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
