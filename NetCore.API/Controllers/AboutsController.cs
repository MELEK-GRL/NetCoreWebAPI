using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore.Busiess.Abstract;
using NetCore.DTO.DTOs.AboutDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController(IGenericService<About> _abaoutService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values=_abaoutService.TGetList();
            return Ok(values);
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _abaoutService.TGetById(id);
            return Ok(value);
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _abaoutService.TDelete(id);
            return Ok("Delete");
        }

        [HttpPost]

        public IActionResult Create(CreateAboutDto createAboutDto)
        {
            var newValue = _mapper.Map<About>(createAboutDto);
            _abaoutService.TCreate(newValue);
            return Ok("Create About");
        }

        [HttpPut]

        public IActionResult Update(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _abaoutService.TUpdate(value);
            return Ok("About Update");
        }
        
        
        
    }
}
