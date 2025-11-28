using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore.Busiess.Abstract;
using NetCore.DTO.DTOs.CourseCategoryDtos;
using NetCore.Entity.Entities;

namespace NetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController(IGenericService<CourseCategory> _courseCategoryService,IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values=_courseCategoryService.TGetList();
            return Ok(values);
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var value = _courseCategoryService.TGetById(id);
            return Ok(value);
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseCategoryService.TDelete(id);
            return Ok("Delete");
        }

        [HttpPost]

        public IActionResult Create(CreateCourseCategoryDto createCourseCategoryDto)
        {
            var newValue = _mapper.Map<CourseCategory>(createCourseCategoryDto);
            _courseCategoryService.TCreate(newValue);
            return Ok("Create CourseCategory");
        }

        [HttpPut]

        public IActionResult Update(UpdateCourseCategoryDto updateCourseCategoryDto)
        {
            var value = _mapper.Map<CourseCategory>(updateCourseCategoryDto);
            _courseCategoryService.TUpdate(value);
            return Ok("CourseCategory Update");
        }
    }
}
