using StudentManagementSystem.Entities.CourseEntities;

namespace StudentManagementSystem.Interfaces.CourseServices
{
    public interface ICourseInteractService
    {
        Task<bool> Insert(CourseDetail _model);
        Task<bool> Update(int _id, CourseDetail _model);
        Task<bool> Delete(int _id);
    }
}
