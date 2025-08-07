using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Entities.CourseEntities;
using StudentManagementSystem.Interfaces.CourseServices;

namespace StudentManagementSystem.Controllers.CourseController
{
    [Route("api/Course/Interact")]
    [ApiController]
    public class CourseInteractController : ControllerBase
    {
        private readonly ICourseInteractService courseInteractService;

        public CourseInteractController(ICourseInteractService _courseInteractService)
        {
            courseInteractService = _courseInteractService;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Insert(CourseDetail model)
        {
            var result = await courseInteractService.Insert(model);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<bool>> Update(int id, CourseDetail model)
        {
            var result = await courseInteractService.Update(id, model);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await courseInteractService.Delete(id);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
