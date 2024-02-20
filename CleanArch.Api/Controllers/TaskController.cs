using CleanArch.Api.Models;
using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _service;
        public TaskController(ITaskService service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _service.GetAll();

            if (response == null)
            {
                return NoContent();
            }

            if (response.Errors.Any())
            {
                return BadRequest(response);
            }
            return Ok(response.Result);
        }

        // GET api/<TaskController>/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var response = await _service.GetById(id);

            if (response == null)
            {
                return NoContent();
            }

            if (response.Errors.Any())
            {
                return BadRequest(response);
            }
            return Ok(response.Result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TaskViewModel task)
        {
            var model = new Domain.Entities.Task(task.Description, task.ScheduleDate, task.CreatedAt);

            var response = await _service.Add(model);

            if (response.Errors.Any())
            {
                return BadRequest(response.Errors);
            }
            return Ok(model);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TaskUpdateModel task)
        {
            var model = new Domain.Entities.Task(task.Description, task.ScheduleDate, task.CreatedAt, task.Id);

            var response = _service.Update(model);

            if (response.Errors.Any())
            {
                return BadRequest(response);
            }
            return Ok(response);
        }

        // DELETE api/<TaskController>/5
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _service.Delete(id);
            if (response.Errors.Any())
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
