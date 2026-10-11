using System.ComponentModel.DataAnnotations;

namespace SchoolSMS.DTOs.StudentDTOs
{
    public class StudentCreateDTOS
    {
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(100)]
        public string FullName { get; set; }
        [Required, EmailAddress]
        public string Eamil { get; set; }
        [Required, Phone]
        public string Phone { get; set; }
        [Required]
        public DateOnly BirthDate { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
