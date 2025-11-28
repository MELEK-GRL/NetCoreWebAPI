using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NetCore.DTO.DTOs.AboutDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Mapping;

public class AboutMapping:Profile
{
    public AboutMapping()
    {
        CreateMap<CreateAboutDto, About>().ReverseMap();
        CreateMap<UpdateAboutDto, About>().ReverseMap();
    }
}