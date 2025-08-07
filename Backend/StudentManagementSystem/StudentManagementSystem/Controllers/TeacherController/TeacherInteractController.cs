using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Entities.TeacherEntities;
using StudentManagementSystem.Interfaces.TeacherServices;

namespace StudentManagementSystem.Controllers.TeacherController
{
    [Route("api/Teacher/Interact")]
    [ApiController]
    public class TeacherInteractController : ControllerBase
    {
        private readonly ITeacherInteractService teacherInteractService;

        public TeacherInteractController(ITeacherInteractService _teacherInteractService)
        {
            teacherInteractService = _teacherInteractService;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Insert(TeacherDetail model)
        {
            var result = await teacherInteractService.Insert(model);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<bool>> Update(int id, TeacherDetail model)
        {
            var result = await teacherInteractService.Update(id, model);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await teacherInteractService.Delete(id);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
