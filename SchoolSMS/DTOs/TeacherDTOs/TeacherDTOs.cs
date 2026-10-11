using System.ComponentModel.DataAnnotations;

namespace SchoolSMS.DTOs.TeacherDTOs
{
    public class TeacherDTOs
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
