using StudentManagementSystem.Entities.GradeEntities;

namespace StudentManagementSystem.Interfaces.GradeServices
{
    public interface IGradeService
    {
        Task<List<GradeDetailView>> Search(int _pageNumber = 1, int _pageSize = 10, string? _name = null);
        Task<GradeDetail> Select(int _id);
    }
}
