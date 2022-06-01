using EducationCenterUoW.Data.Contexts;
using EducationCenterUoW.Data.IRepositories;
using EducationCenterUoW.Domain.Entities.Students;
using Serilog;

namespace EducationCenterUoW.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(EducationCenterDbContext dbContext, ILogger logger) 
            : base(dbContext, logger)
        {
        }
    }
}
