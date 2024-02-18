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
                    PhoneNumber = "123-456-7890",
                    Email = "john.smith@example.com",
                    Gender = "Male",
                    DateOfBirth = new DateOnly(1999, 5, 15),
                    Address = "123 Main St, City",
                    Course = "Engineering",
                    Semester = "1st Semester",
                    YearLevel = "2nd Year",
                    Section = "A",
                    Subjects = "Math,English,Science",
                    DateModified = DateTime.Now
                },
                new Student
                {
                    StudentId = 2,
                    FullName = "Emily Johnson",
                    PhoneNumber = "987-654-3210",
                    Email = "emily.johnson@example.com",
                    Gender = "Female",
                    DateOfBirth = new DateOnly(2000, 2, 20),
                    Address = "456 Elm St, Town",
                    Course = "Business",
                    Semester = "2nd Semester",
                    YearLevel = "1st Year",
                    Section = "B",
                    Subjects = "History,Economics",
                    DateModified = DateTime.Now
                },
                new Student
                {
                    StudentId = 3,
                    FullName = "Michael Brown",
                    PhoneNumber = "555-123-4567",
                    Email = "michael.brown@example.com",
                    Gender = "Male",
                    DateOfBirth = new DateOnly(1998, 11, 10),
                    Address = "789 Oak St, Village",
                    Course = "Psychology",
                    Semester = "1st Semester",
                    YearLevel = "3rd Year",
                    Section = "C",
                    Subjects = "Psychology,Sociology",
                    DateModified = DateTime.Now
                }
            );
        }
    }
}
