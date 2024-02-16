using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentWebApp.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public string Address { get; set; } = string.Empty;
        [Required]
        public string Course { get; set; }
        [Required]
        public string Semester { get; set; }
        [Required]
        public string YearLevel { get; set; }
        [Required]
        public string Section { get; set; }
        // <subjects>
        public DateTime DateModified { get; set; }
    }
}
