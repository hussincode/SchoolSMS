using AutoMapper;
using SchoolSMS.DTOs.CourseDTOs;
using SchoolSMS.Models;

namespace SchoolSMS.Map
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseDTO>().ReverseMap();
            CreateMap<Course, CourseCreateDTO>().ReverseMap();
        }
    }
}
