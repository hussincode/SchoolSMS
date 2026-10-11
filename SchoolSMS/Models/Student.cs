using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SchoolSMS.Models
{
    [Index(nameof(Eamil), IsUnique = true)]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3),MaxLength(100)]
        public string FullName { get; set; }
        [Required,EmailAddress]
        public string Eamil { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required]
        public DateOnly BirthDate { get; set; }
        [Required]
        public string Gender { get; set; }
        public StudentProfile StudentProfile { get; set; }
        public List<Enrollment> Enrollments { get; set; }

    }
}
