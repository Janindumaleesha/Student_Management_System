using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Entities.StudentEntities;
using StudentManagementSystem.Interfaces.StudentInterfaces;

namespace StudentManagementSystem.Controllers.StudentController
{
    [Route("api/Student/Interact")]
    [ApiController]
    public class StudentInteractController : ControllerBase
    {
        private readonly IStudentInteractService studentInteractService;

        public StudentInteractController(IStudentInteractService _studentInteractService)
        {
            studentInteractService = _studentInteractService;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Insert(StudentDetail model)
        {
            var result = await studentInteractService.Insert(model);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<bool>> Update(int id, StudentDetail model)
        {
            var result = await studentInteractService.Update(id, model);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var result = await studentInteractService.Delete(id);

            if (result == false)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
