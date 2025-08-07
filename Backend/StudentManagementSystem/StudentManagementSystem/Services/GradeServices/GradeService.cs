using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Entities.GradeEntities;
using StudentManagementSystem.Interfaces.GradeServices;

namespace StudentManagementSystem.Services.GradeServices
{
    public class GradeService : IGradeService
    {
        private readonly DataContext context;

        public GradeService(DataContext _context)
        {
            context = _context;
        }

        public async Task<List<GradeDetailView>> Search(int _pageNumber = 1, int _pageSize = 10, string? _name = null)
        {
            try
            {
                var query = from grade in context.Grades
                            join student in context.Students on grade.StudentId equals student.Id
                            join course in context.Courses on grade.CourseId equals course.Id
                            select new GradeDetailView
                            {
                                GradeId = grade.Id,
                                StudentName = student.Name,
                                CourseName = course.Name,
                                Score = grade.Score,
                                LetterGrade = grade.LetterGrade
                            };

                if (!string.IsNullOrWhiteSpace(_name))
                {
                    query = query.Where(x => x.StudentName.Contains(_name) || x.CourseName.Contains(_name));
                }

                var result = await query
                    .OrderBy(x => x.GradeId)
                    .Skip((_pageNumber - 1) * _pageSize)
                    .Take(_pageSize)
                    .ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine(ex.StackTrace);

                throw;
            }
        }

        public async Task<GradeDetail> Select(int _id)
        {
            try
            {
                var result = await context.Grades.FindAsync(_id);

                if (result == null)
                    throw new Exception("Not found result.");

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine(ex.StackTrace);

                throw;
            }
        }
    }
}
