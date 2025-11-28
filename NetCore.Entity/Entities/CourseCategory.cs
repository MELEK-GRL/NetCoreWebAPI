namespace NetCore.Entity.Entities;

public class CourseCategory
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public string Icon { get; set; }
    public string Descripton { get; set; }
    public bool IsShown { get; set; }
    public List<Course> Courses { get; set; }
}