using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStoreProject.Migrations
{
    public partial class migdirector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "DirectorId", "DirectorName", "DirectorSurname" },
                values: new object[,]
                {
                    { 1, "Director1", "DirectorSurname2" },
                    { 2, "Director2", "DirectorSurname3" },
                    { 3, "Director3", "DirectorSurname3" },
                    { 4, "Director4", "DirectorSurname4" },
                    { 5, "Director5", "DirectorSurname5" },
                    { 6, "Director6", "DirectorSurname6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "DirectorId",
                keyValue: 6);
        }
    }
}
