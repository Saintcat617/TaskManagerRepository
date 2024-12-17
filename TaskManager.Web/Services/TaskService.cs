namespace TaskManager.Web.Services
{
    using System.Net.Http.Json;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class TaskService
    {
        private readonly HttpClient _httpClient;

        public TaskService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Tarea>> GetTasks()
        {
            return await _httpClient.GetFromJsonAsync<List<Tarea>>("/api/tasks");
        }

        public async Task<bool> CreateTask(Tarea tarea)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/tasks", tarea);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateTask(Tarea tarea)
        {
            var response = await _httpClient.PutAsJsonAsync($"/api/tasks/{tarea.Id}", tarea);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteTask(int id)
        {
            var response = await _httpClient.DeleteAsync($"/api/tasks/{id}");
            return response.IsSuccessStatusCode;
        }
    }

    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }

}
