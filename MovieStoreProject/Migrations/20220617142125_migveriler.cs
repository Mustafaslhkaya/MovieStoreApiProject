using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStoreProject.Migrations
{
    public partial class migveriler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "ActorName", "ActorSurname" },
                values: new object[,]
                {
                    { 1, "Actor1", "ActorSurname1" },
                    { 2, "Actor2", "ActorSurname2" },
                    { 3, "Actor3", "ActorSurname3" },
                    { 4, "Actor4", "ActorSurname4" },
                    { 5, "Actor5", "ActorSurname5" },
                    { 6, "Actor6", "ActorSurname6" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerName", "CustomerSurname", "FavouriteCategories" },
                values: new object[,]
                {
                    { 6, "Customer6", "CustomerSurname6", 1 },
                    { 5, "Customer5", "CustomerSurname5", 1 },
                    { 4, "Customer4", "CustomerSurname4", 2 },
                    { 2, "Customer2", "CustomerSurname2", 4 },
                    { 1, "Customer1", "CustomerSurname1", 2 },
                    { 3, "Customer3", "CustomerSurname3", 3 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "DirectorId", "MovieCategory", "MovieName", "MovieYear", "Price" },
                values: new object[,]
                {
                    { 7, 6, 4, "Movie7", new DateTime(2022, 6, 17, 17, 21, 25, 18, DateTimeKind.Local).AddTicks(8693), 700m },
                    { 1, 1, 2, "Movie1", new DateTime(2022, 6, 17, 17, 21, 25, 18, DateTimeKind.Local).AddTicks(1726), 1500m },
                    { 2, 2, 3, "Movie2", new DateTime(2022, 6, 17, 17, 21, 25, 18, DateTimeKind.Local).AddTicks(8674), 1502m },
                    { 3, 1, 1, "Movie3", new DateTime(2022, 6, 17, 17, 21, 25, 18, DateTimeKind.Local).AddTicks(8687), 1000m },
                    { 4, 4, 2, "Movie4", new DateTime(2022, 6, 17, 17, 21, 25, 18, DateTimeKind.Local).AddTicks(8689), 100m },
                    { 5, 3, 4, "Movie5", new DateTime(2022, 6, 17, 17, 21, 25, 18, DateTimeKind.Local).AddTicks(8690), 350m },
                    { 6, 5, 3, "Movie6", new DateTime(2022, 6, 17, 17, 21, 25, 18, DateTimeKind.Local).AddTicks(8691), 500m },
                    { 8, 6, 1, "Movie8", new DateTime(2022, 6, 17, 17, 21, 25, 18, DateTimeKind.Local).AddTicks(8694), 850m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "MovieId", "Price", "PurchaseDate" },
                values: new object[,]
                {
                    { 1, 1, 2, 2000m, new DateTime(2022, 6, 17, 17, 21, 25, 19, DateTimeKind.Local).AddTicks(3114) },
                    { 7, 3, 2, 2000m, new DateTime(2022, 6, 17, 17, 21, 25, 19, DateTimeKind.Local).AddTicks(3350) },
                    { 2, 3, 3, 1000m, new DateTime(2022, 6, 17, 17, 21, 25, 19, DateTimeKind.Local).AddTicks(3342) },
                    { 3, 6, 4, 2000m, new DateTime(2022, 6, 17, 17, 21, 25, 19, DateTimeKind.Local).AddTicks(3346) },
                    { 6, 2, 5, 2000m, new DateTime(2022, 6, 17, 17, 21, 25, 19, DateTimeKind.Local).AddTicks(3349) },
                    { 4, 5, 7, 2000m, new DateTime(2022, 6, 17, 17, 21, 25, 19, DateTimeKind.Local).AddTicks(3347) },
                    { 5, 3, 7, 2000m, new DateTime(2022, 6, 17, 17, 21, 25, 19, DateTimeKind.Local).AddTicks(3348) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 7);
        }
    }
}
