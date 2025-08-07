using StudentManagementSystem.Entities.GradeEntities;

namespace StudentManagementSystem.Interfaces.GradeServices
{
    public interface IGradeInteractService
    {
        Task<bool> Insert(GradeDetail _model);
        Task<bool> Update(int _id, GradeDetail _model);
        Task<bool> Delete(int _id);
    }
}
