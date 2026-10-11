using SchoolSMS.Data;
using SchoolSMS.Genaric;
using SchoolSMS.Repo.Inter;

namespace SchoolSMS.Repo.Imp
{
    public class Enrollment : GenaricRepo<Enrollment>, IEnrollment
    {
        private readonly AppDBContext _context;
        public Enrollment(AppDBContext context) : base(context)
        {   
            _context = context;
        }

        
    }
}
