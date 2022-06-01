using EducationCenterUoW.Domain.Commons;
using EducationCenterUoW.Domain.Configurations;
using EducationCenterUoW.Domain.Entities.Students;
using EducationCenterUoW.Service.DTOs.Students;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EducationCenterUoW.Service.Interfaces
{
    public interface IStudentService
    {
        Task<BaseResponse<Student>> CreateAsync(StudentForCreationDto studentDto);
        Task<BaseResponse<Student>> GetAsync(Expression<Func<Student, bool>> expression);
        Task<BaseResponse<IEnumerable<Student>>> GetAllAsync(PaginationParams @params, Expression<Func<Student, bool>> expression = null);
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<Student, bool>> expression);
        Task<BaseResponse<Student>> UpdateAsync(Guid id, StudentForCreationDto studentDto);

        Task<string> SaveFileAsync(Stream file, string fileName);
    }
}
