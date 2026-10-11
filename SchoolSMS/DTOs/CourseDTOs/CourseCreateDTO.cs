using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolSMS.DTOs.CourseDTOs
{
    public class CourseCreateDTO
    {
        [Required, MinLength(3), MaxLength(100)]
        public string Title { get; set; }
        [Required, Range(1, 6)]
        public int CreditHours { get; set; }
        [Required, ForeignKey("Teacher")]
        public int TeacherId { get; set; }
    }
}
