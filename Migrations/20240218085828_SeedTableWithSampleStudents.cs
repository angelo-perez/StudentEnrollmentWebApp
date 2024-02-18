using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentEnrollmentWebApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedTableWithSampleStudents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "Course", "DateModified", "DateOfBirth", "Email", "FullName", "Gender", "PhoneNumber", "Section", "Semester", "Subjects", "YearLevel" },
                values: new object[,]
                {
                    { 1, "123 Main St, City", "Engineering", new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5049), new DateOnly(1999, 5, 15), "john.smith@example.com", "John Smith", "Male", "+639123456789", "A", "1st Semester", "Math,English,Science", "2nd Year" },
                    { 2, "456 Elm St, Town", "Business", new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5054), new DateOnly(2000, 2, 20), "emily.johnson@example.com", "Emily Johnson", "Female", "+639876543210", "B", "2nd Semester", "History,Economics", "1st Year" },
                    { 3, "789 Oak St, Village", "Psychology", new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5056), new DateOnly(1998, 11, 10), "michael.brown@example.com", "Michael Brown", "Male", "+635551234567", "C", "1st Semester", "Psychology,Sociology", "3rd Year" },
                    { 4, "101 Pine St, Suburb", "Computer Science", new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5059), new DateOnly(2001, 7, 8), "sarah.lee@example.com", "Sarah Lee", "Female", "+632223334444", "D", "2nd Semester", "Programming,Algorithms", "2nd Year" },
                    { 5, "202 Maple St, Rural", "Nursing", new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5061), new DateOnly(1997, 9, 25), "david.garcia@example.com", "David Garcia", "Male", "+637778889999", "A", "1st Semester", "Anatomy,Physiology", "4th Year" },
                    { 6, "303 Cedar St, Countryside", "Economics", new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5064), new DateOnly(1999, 12, 30), "jessica.martinez@example.com", "Jessica Martinez", "Female", "+634445556666", "B", "2nd Semester", "Microeconomics,Macroeconomics", "3rd Year" },
                    { 7, "505 Birch St, Mountains", "Biology", new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5066), new DateOnly(2002, 3, 18), "william.taylor@example.com", "William Taylor", "Male", "+639998887777", "C", "1st Semester", "Biology,Chemistry", "1st Year" },
                    { 8, "707 Walnut St, Beach", "English", new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5069), new DateOnly(1998, 8, 5), "olivia.anderson@example.com", "Olivia Anderson", "Female", "+636667778888", "D", "2nd Semester", "Literature,Writing", "4th Year" },
                    { 9, "909 Pineapple St, Island", "Chemistry", new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5071), new DateOnly(2000, 10, 12), "ethan.martinez@example.com", "Ethan Martinez", "Male", "+633322211111", "A", "1st Semester", "Organic Chemistry,Inorganic Chemistry", "2nd Year" },
                    { 10, "808 Lemon St, Coastal", "History", new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5074), new DateOnly(1997, 4, 28), "sophia.rodriguez@example.com", "Sophia Rodriguez", "Female", "+631112223333", "B", "2nd Semester", "World History,American History", "3rd Year" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
