using EducationCenterUoW.Domain.Entities.Courses;
using EducationCenterUoW.Domain.Entities.Groups;
using EducationCenterUoW.Domain.Entities.Students;
using EducationCenterUoW.Domain.Entities.Teachers;
using Microsoft.EntityFrameworkCore;

namespace EducationCenterUoW.Data.Contexts
{
    public class EducationCenterDbContext : DbContext
    {
        public EducationCenterDbContext(DbContextOptions<EducationCenterDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
    }
}
