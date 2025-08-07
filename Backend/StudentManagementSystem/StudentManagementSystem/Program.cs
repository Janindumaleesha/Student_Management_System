using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Interfaces.CourseServices;
using StudentManagementSystem.Interfaces.GradeServices;
using StudentManagementSystem.Interfaces.StudentInterfaces;
using StudentManagementSystem.Interfaces.TeacherServices;
using StudentManagementSystem.Services.CourseServices;
using StudentManagementSystem.Services.GradeServices;
using StudentManagementSystem.Services.StudentServices;
using StudentManagementSystem.Services.TeacherServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IStudentInteractService, StudentInteractService>();
builder.Services.AddScoped<IStudentService, StudentService>();

builder.Services.AddScoped<ICourseInteractService, CourseInteractService>();
builder.Services.AddScoped<ICourseService, CourseService>();

builder.Services.AddScoped<ITeacherInteractService, TeacherInteractService>();
builder.Services.AddScoped<ITeacherService, TeacherService>();

builder.Services.AddScoped<IGradeInteractService, GradeInteractService>();
builder.Services.AddScoped<IGradeService, GradeService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
