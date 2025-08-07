using StudentManagementSystem.Entities.StudentEntities;

namespace StudentManagementSystem.Interfaces.StudentInterfaces
{
    public interface IStudentService
    {
        Task<List<StudentDetail>> Search(int _pageNumber = 1, int _pageSize = 10, string? _name = null);
        Task<StudentDetail> Select(int _id);
    }
}
