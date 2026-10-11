using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SchoolSMS.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(100)]
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required]
        public DateOnly BirthDate { get; set; }
        public List<Course> Courses { get; set; }
    }
}
