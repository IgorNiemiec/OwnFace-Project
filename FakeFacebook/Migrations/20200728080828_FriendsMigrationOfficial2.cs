using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeFacebook.Migrations
{
    public partial class FriendsMigrationOfficial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Active",
                table: "Account",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Active",
                table: "Account",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool));
        }
    }
}
