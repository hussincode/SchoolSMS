using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSMS.DTOs.StudentDTOs;
using SchoolSMS.Models;
using SchoolSMS.UnitOfWork;

namespace SchoolSMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly  IMapper mapper;

        public StudentController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _unitOfWork.Student.GetAll();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _unitOfWork.Student.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> Add(StudentCreateDTOS dto)
        {
            var student = mapper.Map<Student>(dto);
            await _unitOfWork.Student.Add(student);
            await _unitOfWork.Save();
            return Ok(student);
        }

        [HttpGet("GetStudentByName/{name}")]
        public async Task<IActionResult> GetStudentByName(string name)
        {
            var student = await _unitOfWork.Student.GetByName(name);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpGet("FilterByGender/{gender}")]
        public async Task<IActionResult> FilterByGender(string gender)
        {
            var student = await _unitOfWork.Student.FilterByGrade(gender);
            if (student == null)
            {
               return NotFound();
            }
            return Ok(student);
        }

        [HttpGet("GetStudents")]
        public async Task<IActionResult> GetStudents(int pagenum, int pagesize)
        {
            var students = await _unitOfWork.Student.GetStudents(pagenum, pagesize);
            return Ok(students);
        }
    }
}
