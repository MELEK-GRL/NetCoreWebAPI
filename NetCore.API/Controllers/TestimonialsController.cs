using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore.Busiess.Abstract;
using NetCore.DTO.DTOs.TestimonialDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController(IGenericService<Testimonial> _testimonialService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values=_testimonialService.TGetList();
            return Ok(values);
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _testimonialService.TDelete(id);
            return Ok("Delete");
        }

        [HttpPost]

        public IActionResult Create(CreateTestimonialDto createTestimonialDto)
        {
            var newValue = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialService.TCreate(newValue);
            return Ok("Create Testimonial");
        }

        [HttpPut]

        public IActionResult Update(UpdateTestimonialDto updateTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialDto);
            _testimonialService.TUpdate(value);
            return Ok("Testimonial Update");
        }
    }
}
