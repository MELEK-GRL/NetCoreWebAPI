using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore.Busiess.Abstract;
using NetCore.DTO.DTOs.MessageDtos;
using NetCore.Entity.Entities;
using NuGet.Protocol.Plugins;

namespace NetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesaggeContactsController(IGenericService<MesaggeContact> _messageContantService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values=_messageContantService.TGetList();
            return Ok(values);
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _messageContantService.TGetById(id);
            return Ok(value);
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _messageContantService.TDelete(id);
            return Ok("Delete");
        }

        [HttpPost]

        public IActionResult Create(CreateMesaggeContactDto createMesaggeContactDto)
        {
            var newValue = _mapper.Map<MesaggeContact>(createMesaggeContactDto);
            _messageContantService.TCreate(newValue);
            return Ok("Create Message");
        }

        [HttpPut]

        public IActionResult Update(UpdateMesaggeContactDto updateMesaggeContactDto)
        {
            var value = _mapper.Map<MesaggeContact>(updateMesaggeContactDto);
            _messageContantService.TUpdate(value);
            return Ok("Message Update");
        }
        
    }
}
