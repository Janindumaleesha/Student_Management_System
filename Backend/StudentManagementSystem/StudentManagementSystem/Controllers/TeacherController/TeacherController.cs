using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Entities.TeacherEntities;
using StudentManagementSystem.Interfaces.TeacherServices;

namespace StudentManagementSystem.Controllers.TeacherController
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService teacherService;

        public TeacherController(ITeacherService _teacherService)
        {
            teacherService = _teacherService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TeacherDetail>>> Search(int pageNumber = 1, int pageSize = 10, string? name = null)
        {
            var result = await teacherService.Search(pageNumber, pageSize, name);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<TeacherDetail>> Select(int id)
        {
            var result = await teacherService.Select(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
