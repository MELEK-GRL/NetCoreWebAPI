using AutoMapper;
using NetCore.DTO.DTOs.SubScriberDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Mapping;

public class SubScriberMapping:Profile
{
    public SubScriberMapping()
    {
        CreateMap<CreateSubScriberDto, SubScriber>().ReverseMap();
        CreateMap<UpdateSubScriberDto, SubScriber>().ReverseMap();
    }
}