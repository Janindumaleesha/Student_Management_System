using StudentManagementSystem.Entities.GradeEntities;

namespace StudentManagementSystem.Interfaces.GradeServices
{
    public interface IGradeService
    {
        Task<List<GradeDetail>> Search();
        Task<GradeDetail> Select(int _id);
    }
}
