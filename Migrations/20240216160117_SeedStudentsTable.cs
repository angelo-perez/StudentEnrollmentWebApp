using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentEnrollmentWebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Address", "Course", "DateModified", "DateOfBirth", "Email", "FullName", "Gender", "Section", "Semester", "YearLevel" },
                values: new object[,]
                {
                    { 1, "123 Main St, City", "Engineering", new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(1986), new DateOnly(1999, 5, 15), "john.smith@example.com", "John Smith", "Male", "A", "1st Semester", "2nd Year" },
                    { 2, "456 Elm St, Town", "Business", new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(1998), new DateOnly(2000, 2, 20), "emily.johnson@example.com", "Emily Johnson", "Female", "B", "2nd Semester", "1st Year" },
                    { 3, "789 Oak St, Village", "Psychology", new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2000), new DateOnly(1998, 11, 10), "michael.brown@example.com", "Michael Brown", "Male", "C", "1st Semester", "3rd Year" },
                    { 4, "101 Pine St, Suburb", "Computer Science", new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2002), new DateOnly(2001, 7, 8), "sarah.lee@example.com", "Sarah Lee", "Female", "D", "2nd Semester", "2nd Year" },
                    { 5, "202 Maple St, Rural", "Nursing", new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2004), new DateOnly(1997, 9, 25), "david.garcia@example.com", "David Garcia", "Male", "A", "1st Semester", "4th Year" },
                    { 6, "303 Cedar St, Countryside", "Economics", new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2047), new DateOnly(1999, 12, 30), "jessica.martinez@example.com", "Jessica Martinez", "Female", "B", "2nd Semester", "3rd Year" },
                    { 7, "505 Birch St, Mountains", "Biology", new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2049), new DateOnly(2002, 3, 18), "william.taylor@example.com", "William Taylor", "Male", "C", "1st Semester", "1st Year" },
                    { 8, "707 Walnut St, Beach", "English", new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2051), new DateOnly(1998, 8, 5), "olivia.anderson@example.com", "Olivia Anderson", "Female", "D", "2nd Semester", "4th Year" },
                    { 9, "909 Pineapple St, Island", "Chemistry", new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2053), new DateOnly(2000, 10, 12), "ethan.martinez@example.com", "Ethan Martinez", "Male", "A", "1st Semester", "2nd Year" },
                    { 10, "808 Lemon St, Coastal", "History", new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2055), new DateOnly(1997, 4, 28), "sophia.rodriguez@example.com", "Sophia Rodriguez", "Female", "B", "2nd Semester", "3rd Year" }
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

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 10);
        }
    }
}
