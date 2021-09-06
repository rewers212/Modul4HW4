using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW4.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Office",
                columns: new[] { "Title", "Location", "Title1" },
                values: new object[,]
                {
                    { 1, "USA", "USAOffice" },
                    { 2, "Russia", "RussiaOffice" }
                });

            migrationBuilder.InsertData(
                table: "Title",
                columns: new[] { "TitleId", "Name" },
                values: new object[,]
                {
                    { 1, "Developer" },
                    { 2, "QA" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "FirstName", "HiredDate", "LastName", "OfficeId", "TitleId" },
                values: new object[] { 1, new DateTime(1961, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom", new DateTime(1985, 11, 21, 9, 30, 12, 0, DateTimeKind.Unspecified), "Soyer", 1, 1 });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DateOfBirth", "FirstName", "HiredDate", "LastName", "OfficeId", "TitleId" },
                values: new object[] { 2, new DateTime(1993, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avram", new DateTime(2015, 8, 1, 11, 22, 1, 0, DateTimeKind.Unspecified), "Linkoln", 2, 2 });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeProjectId", "EmployeeId", "ProjectId", "Rate", "StartedDate" },
                values: new object[] { 1, 1, 1, 1000m, new DateTime(1999, 11, 11, 11, 30, 22, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "EmployeeProject",
                columns: new[] { "EmployeeProjectId", "EmployeeId", "ProjectId", "Rate", "StartedDate" },
                values: new object[] { 2, 2, 2, 2000m, new DateTime(1777, 7, 1, 11, 22, 11, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeProject",
                keyColumn: "EmployeeProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "Title",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Office",
                keyColumn: "Title",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Title",
                keyColumn: "TitleId",
                keyValue: 2);
        }
    }
}
