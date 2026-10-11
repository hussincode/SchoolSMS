using System.ComponentModel.DataAnnotations;

namespace SchoolSMS.DTOs.StudentDTOs
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Eamil { get; set; }
        public string Phone { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Gender { get; set; }
    }
}
