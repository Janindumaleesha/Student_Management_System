using StudentManagementSystem.Data;
using StudentManagementSystem.Entities.TeacherEntities;
using StudentManagementSystem.Interfaces.TeacherServices;

namespace StudentManagementSystem.Services.TeacherServices
{
    public class TeacherInteractService : ITeacherInteractService
    {
        private readonly DataContext context;
        private readonly ITeacherService teacherService;

        public TeacherInteractService(DataContext _context, ITeacherService _teacherService)
        {
            context = _context;
            teacherService = _teacherService;
        }

        public async Task<bool> Insert(TeacherDetail _model)
        {
            try
            {
                if (context.Teachers.Any(x => x.Name == _model.Name))
                    return false;

                if (context.Teachers.Any(x => x.Email == _model.Email))
                    return false;

                if (context.Teachers.Any(x => x.Phone == _model.Phone))
                    return false;

                context.Teachers.Add(_model);
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

        public async Task<bool> Update(int _id, TeacherDetail _model)
        {
            try
            {
                var result = await teacherService.Select(_id);

                if (result == null)
                    return false;

                if (context.Teachers.Any(x => x.Id != _id && x.Name == _model.Name))
                    return false;

                if (context.Teachers.Any(x => x.Id != _id && x.Email == _model.Email))
                    return false;

                if (context.Teachers.Any(x => x.Id != _id && x.Phone == _model.Phone))
                    return false;

                result.Name = _model.Name;
                result.Email = _model.Email;
                result.Phone = _model.Phone;

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
                var result = await teacherService.Select(_id);

                if (result == null)
                    return false;

                context.Teachers.Remove(result);
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
