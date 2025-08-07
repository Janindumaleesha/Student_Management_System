using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Entities.CourseEntities;
using StudentManagementSystem.Interfaces.CourseServices;

namespace StudentManagementSystem.Controllers.CourseController
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService _courseService)
        {
            courseService = _courseService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CourseDetail>>> Search(int pageNumber = 1, int pageSize = 10, string? name = null)
        {
            var result = await courseService.Search(pageNumber, pageSize, name);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<CourseDetail>> Select(int id)
        {
            var result = await courseService.Select(id);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
