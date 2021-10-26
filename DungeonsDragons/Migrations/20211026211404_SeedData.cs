using Microsoft.EntityFrameworkCore.Migrations;

namespace DungeonsDragons.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CharacterID",
                table: "Characters",
                newName: "CharacterId");

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Age", "Class", "Gender", "Name", "Weapon" },
                values: new object[,]
                {
                    { 1, "15", "Ranger", "Male", "Hank", "Bow" },
                    { 2, "15", "Cavalier", "Male", "Eric", "Shield" },
                    { 3, "14", "Acrobat", "Female", "Diana", "Staff" },
                    { 4, "14", "Magican", "Male", "Presto", "Hat" },
                    { 5, "13", "Thief", "Female", "Sheila", "Cloak" },
                    { 6, "8", "Barbarian", "Male", "Bobby", "Club" },
                    { 7, "Unknown", "Unicorn", "Female", "Uni", "Teleport" },
                    { 8, "Unknown", "Dungeon Master", "Male", "Dungeon Master", "Magic" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: 8);

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "Characters",
                newName: "CharacterID");
        }
    }
}
