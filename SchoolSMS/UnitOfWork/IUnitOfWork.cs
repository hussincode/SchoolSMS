using SchoolSMS.Genaric;
using SchoolSMS.Models;
using SchoolSMS.Repo.Inter;

namespace SchoolSMS.UnitOfWork
{
    public interface IUnitOfWork
    {
        IStudentRepo Student { get; }
        IcourseRepo Course { get; }
        IGenaricRepo<Teacher> Teacher { get; }
        
        Task Save();
    }
}
