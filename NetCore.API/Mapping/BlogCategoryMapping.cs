using AutoMapper;
using NetCore.DTO.DTOs.BlogCategoryDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Mapping;

public class BlogCategoryMapping:Profile
{
    public BlogCategoryMapping()
    {
        CreateMap<CreateBlogCategoryDto, BlogCategory>().ReverseMap();
        CreateMap<UpdateBlogCategoryDto, BlogCategory>().ReverseMap();
        CreateMap<ResultBlogCategoryDto, BlogCategory>().ReverseMap();
    }
    
}