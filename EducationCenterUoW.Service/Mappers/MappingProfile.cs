using AutoMapper;
using EducationCenterUoW.Domain.Entities.Students;
using EducationCenterUoW.Service.DTOs.Students;

namespace EducationCenterUoW.Service.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentForCreationDto, Student>().ReverseMap();
        }
    }
}
