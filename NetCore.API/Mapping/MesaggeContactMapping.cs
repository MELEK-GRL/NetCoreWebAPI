using AutoMapper;
using NetCore.DTO.DTOs.MessageDtos;
using NetCore.Entity.Entities;


namespace NetCore.API.Mapping;

public class MesaggeContactMapping:Profile
{
    public MesaggeContactMapping()
    {
        CreateMap<CreateMesaggeContactDto, MesaggeContact>().ReverseMap();
        CreateMap<UpdateMesaggeContactDto, MesaggeContact>().ReverseMap();
    }
    
}