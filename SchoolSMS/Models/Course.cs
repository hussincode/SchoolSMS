using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSMS.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(100)]
        public string Title { get; set; }
        [Required, Range(1, 6)]
        public int CreditHours { get; set; }
        [Required, ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
