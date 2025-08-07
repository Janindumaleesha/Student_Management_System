using StudentManagementSystem.Data;
using StudentManagementSystem.Entities.StudentEntities;
using StudentManagementSystem.Interfaces.StudentInterfaces;

namespace StudentManagementSystem.Services.StudentServices
{
    public class StudentInteractService : IStudentInteractService
    {
        private readonly DataContext context;
        private readonly StudentService studentService;

        public StudentInteractService(DataContext _context, StudentService _studentService)
        {
            context = _context;
            studentService = _studentService;
        }

        public async Task<bool> Insert(StudentDetail _model)
        {
            try
            {
                if (context.Students.Any(x => x.Email == _model.Email))
                    return false;

                if (context.Students.Any(x => x.Phone == _model.Phone))
                    return false;

                context.Students.Add(_model);
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

        public async Task<bool> Update(int _id, StudentDetail _model)
        {
            try
            {
                var result = await studentService.Select(_id);

                if (result == null)
                    return false;

                if (context.Students.Any(x => x.Id != _id && x.Email == _model.Email))
                    return false;

                if (context.Students.Any(x => x.Id != _id && x.Phone == _model.Phone))
                    return false;

                result.Name = _model.Name;
                result.Dob = _model.Dob;
                result.Email = _model.Email;
                result.Phone = _model.Phone;
                result.Address = _model.Address;

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
                var result = await studentService.Select(_id);

                if (result == null)
                    return false;

                context.Students.Remove(result);
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
