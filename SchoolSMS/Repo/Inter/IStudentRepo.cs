using SchoolSMS.Genaric;
using SchoolSMS.Models;

namespace SchoolSMS.Repo.Inter
{
    public interface IStudentRepo : IGenaricRepo<Student>
    {
        Task<Student> GetByName(string name);
        Task<Student> FilterByGrade(string Gender);
        Task<List<Student>> GetStudents(int pagenum, int pagesize);
    }
}
