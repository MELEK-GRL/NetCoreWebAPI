using AutoMapper;
using NetCore.DTO.DTOs.BannerDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Mapping;

public class BannerMapping:Profile
{
    public BannerMapping()
    {
        CreateMap<CreateBannerDto, Banner>().ReverseMap();
        CreateMap<UpdateBannerDto, Banner>().ReverseMap();
    }
}