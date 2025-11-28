using AutoMapper;
using NetCore.DTO.DTOs.TestimonialDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Mapping;

public class TestimonialMapping:Profile
{
    public TestimonialMapping()
    {
        CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();
        CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
    }
    
}