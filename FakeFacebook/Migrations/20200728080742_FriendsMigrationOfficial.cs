using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeFacebook.Migrations
{
    public partial class FriendsMigrationOfficial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Friends",
                table: "Account");

            migrationBuilder.AddColumn<int>(
                name: "Active",
                table: "Account",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Account");

            migrationBuilder.AddColumn<int>(
                name: "Friends",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
