namespace NetCore.DTO.DTOs.ContactDtos;

public class UpdateContactDto
{
    public int Id { get; set; }
    public string MapUrl { get; set; }
    public string Address { get; set; }
    public int Phone { get; set; }
    public string Email { get; set; }
}