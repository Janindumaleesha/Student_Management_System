using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Entities.StudentEntities;
using StudentManagementSystem.Interfaces.StudentInterfaces;
using StudentManagementSystem.Services.StudentServices;

namespace StudentManagementSystem.Controllers.StudentController
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService _studentService)
        {
            studentService = _studentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentDetail>>> Search(int pageNumber = 1, int pageSize = 10, string? name = null)
        {
            var result = await studentService.Search(pageNumber, pageSize, name);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<StudentDetail>> Select(int id)
        {
            var result = await studentService.Select(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
