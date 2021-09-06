using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW4.Migrations
{
    public partial class SeedDataFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "ClientId", "Country", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "USA", new DateTime(1943, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", "Kardan" },
                    { 2, "USSR", new DateTime(1993, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yan", "Gus" },
                    { 3, "Italy", new DateTime(1977, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Roberto", "Ravioly" },
                    { 4, "France", new DateTime(2000, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "Taxi" },
                    { 5, "England", new DateTime(1934, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom", "Dom" }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "budget", "ClientId", "Name", "StartedDate" },
                values: new object[,]
                {
                    { 1, 1234m, 1, "SomeProject1", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 412312m, 2, "SomeProject2", new DateTime(2020, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 123124m, 3, "SomeProject3", new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 122231m, 4, "SomeProject4", new DateTime(1991, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 131415m, 5, "SomeProject5", new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Client",
                keyColumn: "ClientId",
                keyValue: 5);
        }
    }
}
