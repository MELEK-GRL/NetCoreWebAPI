using NetCore.DTO.DTOs.BlogCategoryDtos;

namespace NetCore.DTO.DTOs.CourseCategoryDtos;

public class ResultCourseCategoryDto
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public string Icon { get; set; }
    public string Descripton { get; set; }
    public bool IsShown { get; set; }
    public List<ResultBlogCategoryDto> Courses { get; set; }
}