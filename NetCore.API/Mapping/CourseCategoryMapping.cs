using AutoMapper;
using NetCore.DTO.DTOs.CourseCategoryDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Mapping;

public class CourseCategoryMapping:Profile
{
    public CourseCategoryMapping()
    {
        CreateMap<CreateCourseCategoryDto, CourseCategory>().ReverseMap();
        CreateMap<UpdateCourseCategoryDto, CourseCategory>().ReverseMap();
        CreateMap<ResultCourseCategoryDto, CourseCategory>().ReverseMap();
    }
}