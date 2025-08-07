using StudentManagementSystem.Data;
using StudentManagementSystem.Entities.CourseEntities;
using StudentManagementSystem.Interfaces.CourseServices;

namespace StudentManagementSystem.Services.CourseServices
{
    public class CourseInteractService : ICourseInteractService
    {
        private readonly DataContext context;
        private readonly ICourseService courseService;

        public CourseInteractService(DataContext _context, ICourseService _courseService) 
        {
            context = _context;
            courseService = _courseService;
        }

        public async Task<bool> Insert(CourseDetail _model)
        {
            try
            {
                if (context.Courses.Any(x => x.Name == _model.Name))
                    return false;

                if (context.Courses.Any(x => x.Code == _model.Code))
                    return false;

                context.Courses.Add(_model);
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

        public async Task<bool> Update(int _id, CourseDetail _model)
        {
            try
            {
                var result = await courseService.Select(_id);

                if (result == null)
                    return false;

                if (context.Courses.Any(x => x.Id != _id && x.Name == _model.Name))
                    return false;

                if (context.Courses.Any(x => x.Id != _id && x.Code == _model.Code))
                    return false;

                result.Name = _model.Name;
                result.Code = _model.Code;
                result.Description = _model.Description;
                result.Credits = _model.Credits;

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
                var result = await courseService.Select(_id);

                if (result == null)
                    return false;

                context.Courses.Remove(result);
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
