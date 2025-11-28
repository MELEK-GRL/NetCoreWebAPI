using AutoMapper;
using NetCore.DTO.DTOs.ContactDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Mapping;

public class ContactMapping:Profile
{
    public ContactMapping()
    {
        CreateMap<CreateContactDto, Contact>().ReverseMap();
        CreateMap<UpdateContactDto, Contact>().ReverseMap();
    }
}