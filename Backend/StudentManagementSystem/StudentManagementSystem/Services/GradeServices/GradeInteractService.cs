using StudentManagementSystem.Data;
using StudentManagementSystem.Entities.GradeEntities;
using StudentManagementSystem.Interfaces.GradeServices;
using StudentManagementSystem.Services.CourseServices;

namespace StudentManagementSystem.Services.GradeServices
{
    public class GradeInteractService : IGradeInteractService
    {
        private readonly DataContext context;
        private readonly IGradeService gradeService;

        public GradeInteractService(DataContext _context, IGradeService _gradeService)
        {
            context = _context;
            gradeService = _gradeService;
        }

        public async Task<bool> Insert(GradeDetail _model)
        {
            try
            {
                if (context.Students.Any(x => x.Id != _model.StudentId))
                    return false;

                if (context.Courses.Any(x => x.Id != _model.CourseId))
                    return false;

                context.Grades.Add(_model);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine(ex.StackTrace);

                return false;
            }
        }

        public async Task<bool> Update(int _id, GradeDetail _model)
        {
            try
            {
                var result = await gradeService.Select(_id);

                if (result == null)
                    return false;

                if (context.Students.Any(x => x.Id != _model.StudentId))
                    return false;

                if (context.Courses.Any(x => x.Id != _model.CourseId))
                    return false;

                result.StudentId = _model.StudentId;
                result.CourseId = _model.CourseId;
                result.Score = _model.Score;
                result.LetterGrade = _model.LetterGrade;

                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine(ex.StackTrace);

                return false;
            }
        }

        public async Task<bool> Delete(int _id)
        {
            try
            {
                var result = await gradeService.Select(_id);

                if (result == null)
                    return false;

                context.Grades.Remove(result);
                await context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine(ex.StackTrace);

                return false;
            }
        }
    }
}
