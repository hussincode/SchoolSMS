using AutoMapper;
using SchoolSMS.DTOs.TeacherDTOs;
using SchoolSMS.Models;

namespace SchoolSMS.Map
{
    public class TeacherProfile : Profile
    {
        public TeacherProfile()
        {
            CreateMap<Teacher, TeacherDTOs>().ReverseMap();
            CreateMap<Teacher, TeacherCreateDTO>().ReverseMap();
        }
    }
}
