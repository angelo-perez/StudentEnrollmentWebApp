using System.ComponentModel.DataAnnotations;

namespace StudentEnrollmentWebApp.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public string FullName { get; set; }
        [RegularExpression(@"^[^\.\s][\w\-]+(\.[\w\-]+)*@([\w-]+\.)+[\w-]{2,}$", ErrorMessage = "Not a valid email address")]
        public string Email { get; set; }
        [RegularExpression(@"^(?:\+639|\b09|\b9)\d{9}$", ErrorMessage = "Not a valid PH phone number")]
        public string PhoneNumber { get; set; }
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
        [Required]
        public string Subjects {  get; set; }
        public DateTime DateModified { get; set; } = DateTime.Now;
    }
}
