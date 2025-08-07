using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Entities.GradeEntities;
using StudentManagementSystem.Interfaces.GradeServices;

namespace StudentManagementSystem.Controllers.GradeController
{
    [Route("api/Grade/Interact")]
    [ApiController]
    public class GradeInteractController : ControllerBase
    {
        private readonly IGradeInteractService gradeInteractService;

        public GradeInteractController(IGradeInteractService _gradeInteractService)
        {
            gradeInteractService = _gradeInteractService;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Insert(GradeDetail model)
        {
            var result = await gradeInteractService.Insert(model);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<bool>> Update(int id, GradeDetail model)
        {
            var result = await gradeInteractService.Update(id, model);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await gradeInteractService.Delete(id);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
