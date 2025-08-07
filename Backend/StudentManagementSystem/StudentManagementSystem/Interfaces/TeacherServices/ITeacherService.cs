using StudentManagementSystem.Entities.TeacherEntities;

namespace StudentManagementSystem.Interfaces.TeacherServices
{
    public interface ITeacherService
    {
        Task<List<TeacherDetail>> Search(int _pageNumber = 1, int _pageSize = 10, string? _name = null);
        Task<TeacherDetail> Select(int _id);
    }
}
