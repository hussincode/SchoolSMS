using AutoMapper;
using SchoolSMS.DTOs.StudentDTOs;
using SchoolSMS.Models;

namespace SchoolSMS.Map.StudentMap
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student,StudentDTO>().ReverseMap();
            CreateMap<Student, StudentCreateDTOS>().ReverseMap();
        }
    }
}
