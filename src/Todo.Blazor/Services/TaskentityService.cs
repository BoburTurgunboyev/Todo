using System.Net.Http.Json;
using Todo.Blazor.Models;

namespace Todo.Blazor.Services
{
    public class TaskentityService : ITaskentityService
    {
        private readonly HttpClient _httpClient;

        public TaskentityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async ValueTask CreateTaskentityAsync(Taskentity taskentity)
        {
            await _httpClient.PostAsJsonAsync("api/Taskentity/CreateTaskentity",taskentity);
        }

        public async ValueTask DeleteTaskentityAsync(int id)
        {
            await _httpClient.DeleteAsync($"api/Taskentity/DeleteTaskentity?id={id}");
        }

        public async ValueTask<List<Taskentity>> GetAllTaskentityAsync()
        {
            var taskentity = await _httpClient.GetFromJsonAsync<List<Taskentity>>("api/Taskentity/GetAll");
            return taskentity;
        }

        public async ValueTask<Taskentity> GetByIdTaskentityAsync(int id)
        {
            var taskentity = await _httpClient.GetFromJsonAsync<Taskentity>($"api/Taskentity/GetByIdTaskentity?id={id}");
            return taskentity;
        }

        public async ValueTask UpdateTaskentityAsync(Taskentity taskentity)
        {
            await _httpClient.PutAsJsonAsync($"api/Taskentity/UpdateTaskentity?id = {taskentity.Id}",taskentity);
        }
    }
}
