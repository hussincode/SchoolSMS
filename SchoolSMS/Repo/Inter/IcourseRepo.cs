using SchoolSMS.Genaric;
using SchoolSMS.Models;

namespace SchoolSMS.Repo.Inter
{
    public interface IcourseRepo : IGenaricRepo<Course>
    {
        Task<List<Course>>FilterByTeacherIdAndCreditHours(int teacherId, int creditHours);
        Task<Course> SearchByTitle(string title);
    }
}
