using StudentManagementSystem.Entities.TeacherEntities;

namespace StudentManagementSystem.Interfaces.TeacherServices
{
    public interface ITeacherInteractService
    {
        Task<bool> Insert(TeacherDetail _model);
        Task<bool> Update(int _id, TeacherDetail _model);
        Task<bool> Delete(int _id);
    }
}
