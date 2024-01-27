using Microsoft.EntityFrameworkCore;
using Todo.Api.Data;
using Todo.Api.Dtos;
using Todo.Api.Models;

namespace Todo.Api.Services
{
    public class TaskentityService : ITaskentityService
    {
        private readonly AppDbContext _context;



        public async ValueTask<bool> CreateTaskentityAsync(TaskentityDto taskentity)
        {
            var task = new Taskentity()
            {
                Title = taskentity.Title,
                Description = taskentity.Description,
                Priority = taskentity.Priority,
                DueDate = taskentity.DueDate,
                State = taskentity.State,
            };
            var result = await _context.Tasks.AddAsync(task);
            return true;
        }

        public async ValueTask<bool> DeleteTaskentityAsync(int id)
        {
            var task = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == id);
            var result = _context.Tasks.Remove(task);
            return true;
        }

        public async ValueTask<List<Taskentity>> GetAllTaskentityAsync()
        {
            var tasklist = await _context.Tasks.ToListAsync();
            return tasklist;
        }

        public async ValueTask<Taskentity> GetByIdTaskentityAsync(int id)
        {
            var task = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == id);
            return task;

        }

        public async ValueTask<bool> UpdateTaskentityAsync(int id, TaskentityDto taskentity)
        {
            var task = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == id);
            if (task == null)
            {
                return false;
            }

            task.Title = taskentity.Title;
            task.Description = taskentity.Description;
            task.Priority = taskentity.Priority;
            task.DueDate = taskentity.DueDate;
            task.State = taskentity.State;

            var result = _context.Tasks.Update(task);
            return true;

        }
    }
}
