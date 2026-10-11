using SchoolSMS.Data;
using SchoolSMS.Genaric;
using SchoolSMS.Models;
using SchoolSMS.Repo.Inter;

namespace SchoolSMS.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _context;
        public IStudentRepo Student { get; private set; }
        public IcourseRepo Course { get; private set; }
        public IGenaricRepo<Teacher> Teacher { get; private set; }
        public UnitOfWork(AppDBContext context,
            IStudentRepo student,
            IcourseRepo Course,
            IGenaricRepo<Teacher> Teacher)
        {
            _context = context;
            Student = student;
            this.Course = Course;
            this.Teacher = Teacher;
        }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
