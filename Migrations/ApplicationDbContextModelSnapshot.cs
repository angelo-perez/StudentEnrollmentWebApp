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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subjects")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St, City",
                            Course = "Engineering",
                            DateModified = new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5049),
                            DateOfBirth = new DateOnly(1999, 5, 15),
                            Email = "john.smith@example.com",
                            FullName = "John Smith",
                            Gender = "Male",
                            PhoneNumber = "+639123456789",
                            Section = "A",
                            Semester = "1st Semester",
                            Subjects = "Math,English,Science",
                            YearLevel = "2nd Year"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Elm St, Town",
                            Course = "Business",
                            DateModified = new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5054),
                            DateOfBirth = new DateOnly(2000, 2, 20),
                            Email = "emily.johnson@example.com",
                            FullName = "Emily Johnson",
                            Gender = "Female",
                            PhoneNumber = "+639876543210",
                            Section = "B",
                            Semester = "2nd Semester",
                            Subjects = "History,Economics",
                            YearLevel = "1st Year"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Oak St, Village",
                            Course = "Psychology",
                            DateModified = new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5056),
                            DateOfBirth = new DateOnly(1998, 11, 10),
                            Email = "michael.brown@example.com",
                            FullName = "Michael Brown",
                            Gender = "Male",
                            PhoneNumber = "+635551234567",
                            Section = "C",
                            Semester = "1st Semester",
                            Subjects = "Psychology,Sociology",
                            YearLevel = "3rd Year"
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Pine St, Suburb",
                            Course = "Computer Science",
                            DateModified = new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5059),
                            DateOfBirth = new DateOnly(2001, 7, 8),
                            Email = "sarah.lee@example.com",
                            FullName = "Sarah Lee",
                            Gender = "Female",
                            PhoneNumber = "+632223334444",
                            Section = "D",
                            Semester = "2nd Semester",
                            Subjects = "Programming,Algorithms",
                            YearLevel = "2nd Year"
                        },
                        new
                        {
                            Id = 5,
                            Address = "202 Maple St, Rural",
                            Course = "Nursing",
                            DateModified = new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5061),
                            DateOfBirth = new DateOnly(1997, 9, 25),
                            Email = "david.garcia@example.com",
                            FullName = "David Garcia",
                            Gender = "Male",
                            PhoneNumber = "+637778889999",
                            Section = "A",
                            Semester = "1st Semester",
                            Subjects = "Anatomy,Physiology",
                            YearLevel = "4th Year"
                        },
                        new
                        {
                            Id = 6,
                            Address = "303 Cedar St, Countryside",
                            Course = "Economics",
                            DateModified = new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5064),
                            DateOfBirth = new DateOnly(1999, 12, 30),
                            Email = "jessica.martinez@example.com",
                            FullName = "Jessica Martinez",
                            Gender = "Female",
                            PhoneNumber = "+634445556666",
                            Section = "B",
                            Semester = "2nd Semester",
                            Subjects = "Microeconomics,Macroeconomics",
                            YearLevel = "3rd Year"
                        },
                        new
                        {
                            Id = 7,
                            Address = "505 Birch St, Mountains",
                            Course = "Biology",
                            DateModified = new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5066),
                            DateOfBirth = new DateOnly(2002, 3, 18),
                            Email = "william.taylor@example.com",
                            FullName = "William Taylor",
                            Gender = "Male",
                            PhoneNumber = "+639998887777",
                            Section = "C",
                            Semester = "1st Semester",
                            Subjects = "Biology,Chemistry",
                            YearLevel = "1st Year"
                        },
                        new
                        {
                            Id = 8,
                            Address = "707 Walnut St, Beach",
                            Course = "English",
                            DateModified = new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5069),
                            DateOfBirth = new DateOnly(1998, 8, 5),
                            Email = "olivia.anderson@example.com",
                            FullName = "Olivia Anderson",
                            Gender = "Female",
                            PhoneNumber = "+636667778888",
                            Section = "D",
                            Semester = "2nd Semester",
                            Subjects = "Literature,Writing",
                            YearLevel = "4th Year"
                        },
                        new
                        {
                            Id = 9,
                            Address = "909 Pineapple St, Island",
                            Course = "Chemistry",
                            DateModified = new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5071),
                            DateOfBirth = new DateOnly(2000, 10, 12),
                            Email = "ethan.martinez@example.com",
                            FullName = "Ethan Martinez",
                            Gender = "Male",
                            PhoneNumber = "+633322211111",
                            Section = "A",
                            Semester = "1st Semester",
                            Subjects = "Organic Chemistry,Inorganic Chemistry",
                            YearLevel = "2nd Year"
                        },
                        new
                        {
                            Id = 10,
                            Address = "808 Lemon St, Coastal",
                            Course = "History",
                            DateModified = new DateTime(2024, 2, 18, 16, 58, 28, 46, DateTimeKind.Local).AddTicks(5074),
                            DateOfBirth = new DateOnly(1997, 4, 28),
                            Email = "sophia.rodriguez@example.com",
                            FullName = "Sophia Rodriguez",
                            Gender = "Female",
                            PhoneNumber = "+631112223333",
                            Section = "B",
                            Semester = "2nd Semester",
                            Subjects = "World History,American History",
                            YearLevel = "3rd Year"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
