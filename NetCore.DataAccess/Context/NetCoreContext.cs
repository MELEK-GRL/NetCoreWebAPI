using Microsoft.EntityFrameworkCore;
using NetCore.Entity.Entities;

namespace NetCore.DataAccess.NetCoreContext;

public class NetCoreContext:DbContext
{
    public NetCoreContext(DbContextOptions options) : base(options)
    {
        
    }
    public DbSet<About> Abouts { get; set; } //DbSet Veri tabanı tablolorını temsil eder//Veritabanı CRUD işlemlerini yönetir
    public DbSet<Banner> Banners { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogCategory> BlogCategories { get; set; }
    public DbSet<Contact> Contents { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseCategory> CourseCategories { get; set; }
    public DbSet<MesaggeContact> Mesagges { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<SubScriber> SubScribers { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }
}