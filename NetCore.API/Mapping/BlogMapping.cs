using AutoMapper;
using NetCore.DTO.DTOs.BannerDtos;
using NetCore.DTO.DTOs.BlogDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Mapping;

public class BlogMapping:Profile
{
    public BlogMapping()
    {
        CreateMap<CreateBlogDto, Blog>().ReverseMap();
        CreateMap<UpdateBlogDto, Blog>().ReverseMap();
        CreateMap<ResultBlogDto, Blog>().ReverseMap();
    }
    
}