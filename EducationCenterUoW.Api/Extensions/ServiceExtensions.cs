using EducationCenterUoW.Data.IRepositories;
using EducationCenterUoW.Data.Repositories;
using EducationCenterUoW.Service.Interfaces;
using EducationCenterUoW.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EducationCenterUoW.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
