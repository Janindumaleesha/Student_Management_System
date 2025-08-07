using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Entities.CourseEntities;
using StudentManagementSystem.Entities.GradeEntities;
using StudentManagementSystem.Interfaces.GradeServices;

namespace StudentManagementSystem.Controllers.GradeController
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private readonly IGradeService gradeService;

        public GradeController(IGradeService _gradeService)
        {
            gradeService = _gradeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<GradeDetailView>>> Search(int pageNumber = 1, int pageSize = 10, string? name = null)
        {
            var result = await gradeService.Search(pageNumber, pageSize, name);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<CourseDetail>> Select(int id)
        {
            var result = await gradeService.Select(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
