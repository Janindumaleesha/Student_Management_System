using StudentManagementSystem.Data;
using StudentManagementSystem.Entities.TeacherEntities;
using StudentManagementSystem.Interfaces.TeacherServices;

namespace StudentManagementSystem.Services.TeacherServices
{
    public class TeacherService : ITeacherService
    {
        private readonly DataContext context;

        public TeacherService(DataContext _context)
        {
            context = _context;
        }

        public Task<List<TeacherDetail>> Search(int _pageNumber = 1, int _pageSize = 10, string? _name = null)
        {
            throw new NotImplementedException();
        }

        public Task<TeacherDetail> Select(int _id)
        {
            throw new NotImplementedException();
        }
    }
}
