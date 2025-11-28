using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore.Busiess.Abstract;
using NetCore.DTO.DTOs.SubScriberDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubScribersController(IGenericService<SubScriber> _subScriberService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values=_subScriberService.TGetList();
            return Ok(values);
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _subScriberService.TGetById(id);
            return Ok(value);
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _subScriberService.TDelete(id);
            return Ok("Delete");
        }

        [HttpPost]

        public IActionResult Create(CreateSubScriberDto createSubScriberDto)
        {
            var newValue = _mapper.Map<SubScriber>(createSubScriberDto);
            _subScriberService.TCreate(newValue);
            return Ok("Create SubScriber");
        }

        [HttpPut]

        public IActionResult Update(UpdateSubScriberDto updateSubScriberDto)
        {
            var value = _mapper.Map<SubScriber>(updateSubScriberDto);
            _subScriberService.TUpdate(value);
            return Ok("SubScriber Update");
        }
    }
}
