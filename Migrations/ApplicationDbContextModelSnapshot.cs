﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentEnrollmentWebApp.Data;

#nullable disable

namespace StudentEnrollmentWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentEnrollmentWebApp.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Address = "123 Main St, City",
                            Course = "Engineering",
                            DateModified = new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(1986),
                            DateOfBirth = new DateOnly(1999, 5, 15),
                            Email = "john.smith@example.com",
                            FullName = "John Smith",
                            Gender = "Male",
                            Section = "A",
                            Semester = "1st Semester",
                            YearLevel = "2nd Year"
                        },
                        new
                        {
                            StudentId = 2,
                            Address = "456 Elm St, Town",
                            Course = "Business",
                            DateModified = new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(1998),
                            DateOfBirth = new DateOnly(2000, 2, 20),
                            Email = "emily.johnson@example.com",
                            FullName = "Emily Johnson",
                            Gender = "Female",
                            Section = "B",
                            Semester = "2nd Semester",
                            YearLevel = "1st Year"
                        },
                        new
                        {
                            StudentId = 3,
                            Address = "789 Oak St, Village",
                            Course = "Psychology",
                            DateModified = new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2000),
                            DateOfBirth = new DateOnly(1998, 11, 10),
                            Email = "michael.brown@example.com",
                            FullName = "Michael Brown",
                            Gender = "Male",
                            Section = "C",
                            Semester = "1st Semester",
                            YearLevel = "3rd Year"
                        },
                        new
                        {
                            StudentId = 4,
                            Address = "101 Pine St, Suburb",
                            Course = "Computer Science",
                            DateModified = new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2002),
                            DateOfBirth = new DateOnly(2001, 7, 8),
                            Email = "sarah.lee@example.com",
                            FullName = "Sarah Lee",
                            Gender = "Female",
                            Section = "D",
                            Semester = "2nd Semester",
                            YearLevel = "2nd Year"
                        },
                        new
                        {
                            StudentId = 5,
                            Address = "202 Maple St, Rural",
                            Course = "Nursing",
                            DateModified = new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2004),
                            DateOfBirth = new DateOnly(1997, 9, 25),
                            Email = "david.garcia@example.com",
                            FullName = "David Garcia",
                            Gender = "Male",
                            Section = "A",
                            Semester = "1st Semester",
                            YearLevel = "4th Year"
                        },
                        new
                        {
                            StudentId = 6,
                            Address = "303 Cedar St, Countryside",
                            Course = "Economics",
                            DateModified = new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2047),
                            DateOfBirth = new DateOnly(1999, 12, 30),
                            Email = "jessica.martinez@example.com",
                            FullName = "Jessica Martinez",
                            Gender = "Female",
                            Section = "B",
                            Semester = "2nd Semester",
                            YearLevel = "3rd Year"
                        },
                        new
                        {
                            StudentId = 7,
                            Address = "505 Birch St, Mountains",
                            Course = "Biology",
                            DateModified = new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2049),
                            DateOfBirth = new DateOnly(2002, 3, 18),
                            Email = "william.taylor@example.com",
                            FullName = "William Taylor",
                            Gender = "Male",
                            Section = "C",
                            Semester = "1st Semester",
                            YearLevel = "1st Year"
                        },
                        new
                        {
                            StudentId = 8,
                            Address = "707 Walnut St, Beach",
                            Course = "English",
                            DateModified = new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2051),
                            DateOfBirth = new DateOnly(1998, 8, 5),
                            Email = "olivia.anderson@example.com",
                            FullName = "Olivia Anderson",
                            Gender = "Female",
                            Section = "D",
                            Semester = "2nd Semester",
                            YearLevel = "4th Year"
                        },
                        new
                        {
                            StudentId = 9,
                            Address = "909 Pineapple St, Island",
                            Course = "Chemistry",
                            DateModified = new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2053),
                            DateOfBirth = new DateOnly(2000, 10, 12),
                            Email = "ethan.martinez@example.com",
                            FullName = "Ethan Martinez",
                            Gender = "Male",
                            Section = "A",
                            Semester = "1st Semester",
                            YearLevel = "2nd Year"
                        },
                        new
                        {
                            StudentId = 10,
                            Address = "808 Lemon St, Coastal",
                            Course = "History",
                            DateModified = new DateTime(2024, 2, 17, 0, 1, 16, 663, DateTimeKind.Local).AddTicks(2055),
                            DateOfBirth = new DateOnly(1997, 4, 28),
                            Email = "sophia.rodriguez@example.com",
                            FullName = "Sophia Rodriguez",
                            Gender = "Female",
                            Section = "B",
                            Semester = "2nd Semester",
                            YearLevel = "3rd Year"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
