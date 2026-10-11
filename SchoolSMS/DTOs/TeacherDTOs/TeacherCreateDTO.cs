using System.ComponentModel.DataAnnotations;

namespace SchoolSMS.DTOs.TeacherDTOs
{
    public class TeacherCreateDTO
    {
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(100)]
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required]
        public DateOnly BirthDate { get; set; }
    }
}
