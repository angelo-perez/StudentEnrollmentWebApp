using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentEnrollmentWebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Address", "Course", "DateModified", "DateOfBirth", "Email", "FullName", "Gender", "PhoneNumber", "Section", "Semester", "Subjects", "YearLevel" },
                values: new object[,]
                {
                    { 1, "123 Main St, City", "Engineering", new DateTime(2024, 2, 17, 17, 19, 2, 829, DateTimeKind.Local).AddTicks(108), new DateOnly(1999, 5, 15), "john.smith@example.com", "John Smith", "Male", "123-456-7890", "A", "1st Semester", "Math,English,Science", "2nd Year" },
                    { 2, "456 Elm St, Town", "Business", new DateTime(2024, 2, 17, 17, 19, 2, 829, DateTimeKind.Local).AddTicks(126), new DateOnly(2000, 2, 20), "emily.johnson@example.com", "Emily Johnson", "Female", "987-654-3210", "B", "2nd Semester", "History,Economics", "1st Year" },
                    { 3, "789 Oak St, Village", "Psychology", new DateTime(2024, 2, 17, 17, 19, 2, 829, DateTimeKind.Local).AddTicks(173), new DateOnly(1998, 11, 10), "michael.brown@example.com", "Michael Brown", "Male", "555-123-4567", "C", "1st Semester", "Psychology,Sociology", "3rd Year" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);
        }
    }
}
