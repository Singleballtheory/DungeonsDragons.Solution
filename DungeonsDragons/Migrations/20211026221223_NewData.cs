using Microsoft.EntityFrameworkCore.Migrations;

namespace DungeonsDragons.Migrations
{
    public partial class NewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Class",
                table: "Characters",
                newName: "Profession");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Profession",
                table: "Characters",
                newName: "Class");
        }
    }
}
