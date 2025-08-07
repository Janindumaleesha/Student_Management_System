using StudentManagementSystem.Data;
using StudentManagementSystem.Entities.TeacherEntities;
using StudentManagementSystem.Interfaces.TeacherServices;

namespace StudentManagementSystem.Services.TeacherServices
{
    public class TeacherInteractService : ITeacherInteractService
    {
        private readonly DataContext context;

        public TeacherInteractService(DataContext _context)
        {
            context = _context;
        }

        public Task<bool> Insert(TeacherDetail _model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int _id, TeacherDetail _model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int _id)
        {
            throw new NotImplementedException();
        }
    }
}
