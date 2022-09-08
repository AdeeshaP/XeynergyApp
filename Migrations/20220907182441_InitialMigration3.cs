using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xeynergy_App.Migrations
{
    public partial class InitialMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GetFullName",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GetFullName",
                table: "People");
        }
    }
}
