using Microsoft.EntityFrameworkCore;
using SchoolSMS.Data;
using SchoolSMS.Genaric;
using SchoolSMS.Models;
using SchoolSMS.Repo.Inter;

namespace SchoolSMS.Repo.Imp
{
    public class CourseRepo : GenaricRepo<Course>, IcourseRepo
    {
        private readonly AppDBContext _context;
        public CourseRepo(AppDBContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<Course>> FilterByTeacherIdAndCreditHours(int teacherId, int creditHours)
        {
            return await _context.Courses.Where(c => c.TeacherId == teacherId && c.CreditHours == creditHours)
                .ToListAsync();
        }

        public async Task<Course> SearchByTitle(string title)
        {
            return await _context.Courses.FirstOrDefaultAsync(c => c.Title.Equals(title));
        }
    }
}
