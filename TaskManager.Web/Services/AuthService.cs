namespace TaskManager.Web.Services
{
    using System.Net.Http.Json;
    using System.Threading.Tasks;

    public class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> Login(string email, string password)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/auth/login", new { Correo = email, ContraseñaHash = password });

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<dynamic>();
                return result?.token;
            }
            return null;
        }

        public async Task<bool> Register(string email, string password)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/auth/register", new { Correo = email, ContraseñaHash = password });
            return response.IsSuccessStatusCode;
        }
    }

}
