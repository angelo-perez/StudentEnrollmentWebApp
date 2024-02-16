using Microsoft.EntityFrameworkCore;
using StudentEnrollmentWebApp.Models;

namespace StudentEnrollmentWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; } // create table (w/ table name) in db

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FullName = "John Smith",
                    Email = "john.smith@example.com",
                    Gender = "Male",
                    DateOfBirth = new DateOnly(1999, 5, 15),
                    Address = "123 Main St, City",
                    Course = "Engineering",
                    Semester = "1st Semester",
                    YearLevel = "2nd Year",
                    Section = "A",
                    DateModified = DateTime.Now
                },
                new Student
                {
                    StudentId = 2,
                    FullName = "Emily Johnson",
                    Email = "emily.johnson@example.com",
                    Gender = "Female",
                    DateOfBirth = new DateOnly(2000, 2, 20),
                    Address = "456 Elm St, Town",
                    Course = "Business",
                    Semester = "2nd Semester",
                    YearLevel = "1st Year",
                    Section = "B",
                    DateModified = DateTime.Now
                },
                new Student
                {
                    StudentId = 3,
                    FullName = "Michael Brown",
                    Email = "michael.brown@example.com",
                    Gender = "Male",
                    DateOfBirth = new DateOnly(1998, 11, 10),
                    Address = "789 Oak St, Village",
                    Course = "Psychology",
                    Semester = "1st Semester",
                    YearLevel = "3rd Year",
                    Section = "C",
                    DateModified = DateTime.Now
                },
                new Student
                {
                    StudentId = 4,
                    FullName = "Sarah Lee",
                    Email = "sarah.lee@example.com",
                    Gender = "Female",
                    DateOfBirth = new DateOnly(2001, 7, 8),
                    Address = "101 Pine St, Suburb",
                    Course = "Computer Science",
                    Semester = "2nd Semester",
                    YearLevel = "2nd Year",
                    Section = "D",
                    DateModified = DateTime.Now
                },
                new Student
                {
                    StudentId = 5,
                    FullName = "David Garcia",
                    Email = "david.garcia@example.com",
                    Gender = "Male",
                    DateOfBirth = new DateOnly(1997, 9, 25),
                    Address = "202 Maple St, Rural",
                    Course = "Nursing",
                    Semester = "1st Semester",
                    YearLevel = "4th Year",
                    Section = "A",
                    DateModified = DateTime.Now
                },
                new Student
                {
                    StudentId = 6,
                    FullName = "Jessica Martinez",
                    Email = "jessica.martinez@example.com",
                    Gender = "Female",
                    DateOfBirth = new DateOnly(1999, 12, 30),
                    Address = "303 Cedar St, Countryside",
                    Course = "Economics",
                    Semester = "2nd Semester",
                    YearLevel = "3rd Year",
                    Section = "B",
                    DateModified = DateTime.Now
                },
                new Student
                {
                    StudentId = 7,
                    FullName = "William Taylor",
                    Email = "william.taylor@example.com",
                    Gender = "Male",
                    DateOfBirth = new DateOnly(2002, 3, 18),
                    Address = "505 Birch St, Mountains",
                    Course = "Biology",
                    Semester = "1st Semester",
                    YearLevel = "1st Year",
                    Section = "C",
                    DateModified = DateTime.Now
                },
                new Student
                {
                    StudentId = 8,
                    FullName = "Olivia Anderson",
                    Email = "olivia.anderson@example.com",
                    Gender = "Female",
                    DateOfBirth = new DateOnly(1998, 8, 5),
                    Address = "707 Walnut St, Beach",
                    Course = "English",
                    Semester = "2nd Semester",
                    YearLevel = "4th Year",
                    Section = "D",
                    DateModified = DateTime.Now
                },
                new Student
                {
                    StudentId = 9,
                    FullName = "Ethan Martinez",
                    Email = "ethan.martinez@example.com",
                    Gender = "Male",
                    DateOfBirth = new DateOnly(2000, 10, 12),
                    Address = "909 Pineapple St, Island",
                    Course = "Chemistry",
                    Semester = "1st Semester",
                    YearLevel = "2nd Year",
                    Section = "A",
                    DateModified = DateTime.Now
                },
                new Student
                {
                    StudentId = 10,
                    FullName = "Sophia Rodriguez",
                    Email = "sophia.rodriguez@example.com",
                    Gender = "Female",
                    DateOfBirth = new DateOnly(1997, 4, 28),
                    Address = "808 Lemon St, Coastal",
                    Course = "History",
                    Semester = "2nd Semester",
                    YearLevel = "3rd Year",
                    Section = "B",
                    DateModified = DateTime.Now
                }

            );
        }
    }
}
