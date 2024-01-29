using Todo.Blazor.Models;

namespace Todo.Blazor.Services
{
    public interface ITaskentityService
    {
        public ValueTask CreateTaskentityAsync(Taskentity taskentity);
        public ValueTask UpdateTaskentityAsync(Taskentity taskentity);
        public ValueTask DeleteTaskentityAsync(int id);
        public ValueTask<Taskentity> GetByIdTaskentityAsync(int id);
        public ValueTask<List<Taskentity>> GetAllTaskentityAsync();
    }
}
