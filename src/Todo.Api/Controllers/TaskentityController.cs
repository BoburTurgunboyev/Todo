using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.Api.Dtos;
using Todo.Api.Models;
using Todo.Api.Services;

namespace Todo.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TaskentityController : ControllerBase
    {
        private readonly ITaskentityService _taskentityService;

        public TaskentityController(ITaskentityService taskentityService)
        {

            _taskentityService = taskentityService;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateTaskentity(TaskentityDto entity) 
        {
            var taskentity = await _taskentityService.CreateTaskentityAsync(entity);
            return Ok(taskentity);
        }


        [HttpPut]

        public async ValueTask<IActionResult> UpdateTaskentity(int id,TaskentityDto entity)
        {
            var taskentity = await _taskentityService.UpdateTaskentityAsync(id,entity);
            return Ok(taskentity);    
        }
        [HttpDelete]
        public async ValueTask<IActionResult > DeleteTaskentity(int id) 
        {
            var taskentity = await _taskentityService.DeleteTaskentityAsync(id);
            return Ok(taskentity);
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdTaskentity(int id) 
        {
            var taskentity = await _taskentityService.GetByIdTaskentityAsync(id);
            return Ok(taskentity);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAll()
        {
            IEnumerable<Taskentity> taskentities = await _taskentityService.GetAllTaskentityAsync();
            return Ok(taskentities);
        }

        
    }
}
