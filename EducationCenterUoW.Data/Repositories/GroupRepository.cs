using EducationCenterUoW.Data.Contexts;
using EducationCenterUoW.Data.IRepositories;
using EducationCenterUoW.Domain.Entities.Groups;
using Serilog;

namespace EducationCenterUoW.Data.Repositories
{
    public class GroupRepository : GenericRepository<Group>, IGroupRepository
    {
        public GroupRepository(EducationCenterDbContext dbContext, ILogger logger) 
            : base(dbContext, logger)
        {
        }
    }
}
