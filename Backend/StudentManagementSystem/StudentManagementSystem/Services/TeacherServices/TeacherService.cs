using Microsoft.EntityFrameworkCore;
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

        public async Task<List<TeacherDetail>> Search(int _pageNumber = 1, int _pageSize = 10, string? _name = null)
        {
            try
            {
                var query = context.Teachers.AsQueryable();

                if (!string.IsNullOrWhiteSpace(_name))
                {
                    query = query.Where(x => x.Name.Contains(_name));
                }

                var result = await query
                    .OrderBy(s => s.Id)
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

        public async Task<TeacherDetail> Select(int _id)
        {
            try
            {
                var result = await context.Teachers.FindAsync(_id);

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
