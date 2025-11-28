using AutoMapper;
using NetCore.DTO.DTOs.CourseDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Mapping;

public class CourseMapping:Profile
{
    public CourseMapping()
    {
        CreateMap<CreateCourseDto, Course>().ReverseMap();
        CreateMap<UpdateCourseDto, Course>().ReverseMap();
        CreateMap<ResultCourseDto, Course>().ReverseMap();
    }
    
}