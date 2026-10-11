using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolSMS.DTOs.CourseDTOs
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CreditHours { get; set; }
        public int TeacherId { get; set; }
    }
}
