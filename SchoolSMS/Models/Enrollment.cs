using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSMS.Models
{
    public class Enrollment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
        [Range(0, 100)]
        public decimal? Grade { get; set; }
    }
}
