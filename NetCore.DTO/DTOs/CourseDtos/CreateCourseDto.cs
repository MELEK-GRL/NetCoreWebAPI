namespace NetCore.DTO.DTOs.CourseDtos;

public class CreateCourseDto
{

    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public bool IsShown { get; set; }
    public int CourseCategoryId { get; set; }
    public int CategoryId { get; set; } 
 
}