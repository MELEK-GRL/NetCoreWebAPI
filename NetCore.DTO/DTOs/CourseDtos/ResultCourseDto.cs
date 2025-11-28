using NetCore.DTO.DTOs.BlogCategoryDtos;

namespace NetCore.DTO.DTOs.CourseDtos;

public class ResultCourseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public bool IsShown { get; set; }
    public int CourseCategoryId { get; set; }
    public int CategoryId { get; set; } 
    public ResultBlogCategoryDto CourseCategory { get; set; }
}