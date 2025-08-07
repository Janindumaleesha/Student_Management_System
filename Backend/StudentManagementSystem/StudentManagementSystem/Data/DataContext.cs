using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Entities.CourseEntities;
using StudentManagementSystem.Entities.GradeEntities;
using StudentManagementSystem.Entities.StudentEntities;
using StudentManagementSystem.Entities.TeacherEntities;

namespace StudentManagementSystem.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<StudentDetail> Students { get; set; }
        public DbSet<TeacherDetail> Teachers { get; set; }
        public DbSet<CourseDetail> Courses { get; set; }
        public DbSet<GradeDetail> Grades { get; set; }
    }
}
