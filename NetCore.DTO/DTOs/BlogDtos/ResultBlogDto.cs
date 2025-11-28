using NetCore.DTO.DTOs.BlogCategoryDtos;

namespace NetCore.DTO.DTOs.BlogDtos;

public class ResultBlogDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string ImageUrl { get; set; }
    public DateTime BlogDate { get; set; }
    public int BlogCategoryId { get; set; }
    public ResultBlogCategoryDto BlogCategory { get; set; }
}