using Domain.Interfaces;
using NetCoreTraining.Models;

namespace DataAccess.EFCore.Repository
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
