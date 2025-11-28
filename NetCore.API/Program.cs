using System.Reflection;
using Microsoft.EntityFrameworkCore;
using NetCore.Busiess.Abstract;
using NetCore.Busiess.Concrete;
using NetCore.DataAccess.NetCoreContext;
using NetCore.DataAcsess.Abstract;
using NetCore.DataAcsess.Repositories;

var builder = WebApplication.CreateBuilder(args);
//CLİ izin
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReact", policy =>
    {
        policy.AllowAnyHeader()
            .AllowAnyMethod()
            .WithOrigins("http://localhost:3000"); 
    });
});



// AutoMapper
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

// CONTROLLER 
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext
builder.Services.AddDbContext<NetCoreContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
});

//SERVİSLERİ EKLEYELİM
builder.Services.AddScoped(typeof(IRepositroy<>), typeof(GenericRepostroy<>));//DATAACCESS TARAFI AboutsControllers.cs
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericMenager<>));//BUSİESS TARAFI

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseHttpsRedirection();
app.UseCors("AllowReact");//cli

// (ileride policy koyarsın diye dursun)
app.UseAuthorization();

//  CONTROLLER ROUTE'LARI
app.MapControllers();


app.Run();