using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSMS.DTOs.CourseDTOs;
using SchoolSMS.Models;
using SchoolSMS.UnitOfWork;

namespace SchoolSMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;
        public CourseController(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var courses = await _unitOfWork.Course.GetAll();
            return Ok(courses);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var course = await _unitOfWork.Course.GetById(id);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CourseCreateDTO course)
        {
            var data = mapper.Map<Course>(course);
            await _unitOfWork.Course.Add(data);
            await _unitOfWork.Save();
            return Ok(course);
        }

        [HttpGet("/search/{Title}")]
        public async Task<IActionResult> GetByTitle(string Title)
        {
            var course = await _unitOfWork.Course.SearchByTitle(Title);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }

        [HttpGet("/searchByTeacherAndcreditHours/{teacherId}/{creditHours}")]
        public async Task<IActionResult> GetByTeacherAndCreditHours(int teacherId, int creditHours)
        {
            var courses = await _unitOfWork.Course.FilterByTeacherIdAndCreditHours(teacherId, creditHours);
            if (courses == null || !courses.Any())
            {
                return NotFound();
            }
            return Ok(courses);
        }
    }
}
