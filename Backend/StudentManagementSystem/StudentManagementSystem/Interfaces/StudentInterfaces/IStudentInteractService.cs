using StudentManagementSystem.Entities.StudentEntities;

namespace StudentManagementSystem.Interfaces.StudentInterfaces
{
    public interface IStudentInteractService
    {
        Task<bool> Insert(StudentDetail _model);
        Task<bool> Update(int _id, StudentDetail _model);
        Task<bool> Delete(int _id);
    }
}
