using SchoolSMS.Genaric;
using SchoolSMS.Models;

namespace SchoolSMS.Repo.Inter
{
    public interface IEnrollment : IGenaricRepo<Enrollment>
    {
        Task<Enrollment> GetCourseId(int courseId);
        Task<Enrollment> GetTeacherId(int teacherId);
    }
}
