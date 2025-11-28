using AutoMapper;
using NetCore.DTO.DTOs.SocialMediaDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Mapping;

public class SocialMapping:Profile
{
    public SocialMapping()
    {
        CreateMap<CreateSocialMediaDto, SocialMedia>().ReverseMap();
        CreateMap<UpdateSocialMediaDto, SocialMedia>().ReverseMap();
    }
    
}