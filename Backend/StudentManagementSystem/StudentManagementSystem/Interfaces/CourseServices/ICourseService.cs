using StudentManagementSystem.Entities.CourseEntities;

namespace StudentManagementSystem.Interfaces.CourseServices
{
    public interface ICourseService
    {
        Task<List<CourseDetail>> Search(int _pageNumber = 1, int _pageSize = 10, string? _name = null);
        Task<CourseDetail> Select(int _id);
    }
}
