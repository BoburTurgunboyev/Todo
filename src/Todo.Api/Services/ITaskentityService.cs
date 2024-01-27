using Todo.Api.Dtos;
using Todo.Api.Models;

namespace Todo.Api.Services
{
    public interface ITaskentityService
    {
        public ValueTask<bool> CreateTaskentityAsync(TaskentityDto taskentity);
        public ValueTask<bool> UpdateTaskentityAsync(int id, TaskentityDto taskentity);
        public ValueTask<bool> DeleteTaskentityAsync(int id);
        public ValueTask<Taskentity> GetByIdTaskentityAsync(int id);
        public ValueTask<List<Taskentity>> GetAllTaskentityAsync();
    }
}
