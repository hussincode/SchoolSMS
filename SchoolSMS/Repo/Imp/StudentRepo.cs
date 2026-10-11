using Microsoft.EntityFrameworkCore;
using SchoolSMS.Data;
using SchoolSMS.Genaric;
using SchoolSMS.Models;
using SchoolSMS.Repo.Inter;

namespace SchoolSMS.Repo.Imp
{
    public class StudentRepo : GenaricRepo<Student>, IStudentRepo
    {
        private readonly AppDBContext _context;
        public StudentRepo(AppDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Student >FilterByGrade(string gender)
        {
            return await _context.Students.FirstOrDefaultAsync(s => s.Gender.Equals(gender));

        }

        public async Task<Student >GetByName(string name)
        {
            return await _context.Students.FirstOrDefaultAsync(s => s.FullName.Equals(name));
        }
        
        public async Task<List<Student>>GetStudents(int pagenum, int pagesize)
        {
            return await _context.Students.Skip((pagenum -1) * pagesize).Take(pagesize).ToListAsync();
        }

         
    }
}
