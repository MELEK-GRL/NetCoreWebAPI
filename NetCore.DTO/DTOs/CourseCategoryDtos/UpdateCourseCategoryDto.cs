namespace NetCore.DTO.DTOs.CourseCategoryDtos;

public class UpdateCourseCategoryDto
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public string Icon { get; set; }
    public string Descripton { get; set; }
    public bool IsShown { get; set; }

}