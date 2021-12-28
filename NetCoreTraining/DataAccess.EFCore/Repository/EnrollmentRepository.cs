using Domain.Interfaces;
using NetCoreTraining.Models;

namespace DataAccess.EFCore.Repository
{

    public class EnrollmentRepository : GenericRepository<Enrollment>, IEnrollmentRepository
    {
        public EnrollmentRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
