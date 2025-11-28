namespace NetCore.DTO.DTOs.SubScriberDtos;

public class UpdateSubScriberDto
{
    public int Id { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
}