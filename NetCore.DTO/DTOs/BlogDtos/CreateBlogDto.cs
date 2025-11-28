using NetCore.DTO.DTOs.BlogCategoryDtos;
 
 namespace NetCore.DTO.DTOs.BlogDtos;
 
 public class CreateBlogDto
 {
     public string Title { get; set; }
     public string Content { get; set; }
     public string ImageUrl { get; set; }
     public DateTime BlogDate { get; set; }
     public int BlogCategoryId { get; set; }
    
 }