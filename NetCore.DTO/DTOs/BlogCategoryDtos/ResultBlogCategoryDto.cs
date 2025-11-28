using NetCore.DTO.DTOs.BlogDtos;

namespace NetCore.DTO.DTOs.BlogCategoryDtos;

public class ResultBlogCategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ResultBlogDto> Blogs { get; set; }
}