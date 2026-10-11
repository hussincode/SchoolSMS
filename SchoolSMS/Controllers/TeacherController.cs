using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolSMS.DTOs.TeacherDTOs;
using SchoolSMS.Models;
using SchoolSMS.UnitOfWork;

namespace SchoolSMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper mapper;

        public TeacherController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var teachers = await _unitOfWork.Teacher.GetAll();
            return Ok(teachers);
        }

        [HttpPost]

        public async Task<IActionResult> Add(TeacherCreateDTO teacher)
        {
            var data = mapper.Map<Teacher>(teacher);
            await _unitOfWork.Teacher.Add(data);
            await _unitOfWork.Save();
            return Ok(teacher);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, TeacherCreateDTO teacher)
        {
            var existingTeacher = await _unitOfWork.Teacher.GetById(id);
            if (existingTeacher == null)
            {
                return NotFound();
            }
            mapper.Map(teacher, existingTeacher);
            _unitOfWork.Teacher.Update(existingTeacher);
            await _unitOfWork.Save();
            return NoContent();
        }

    }
}
