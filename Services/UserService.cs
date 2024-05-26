using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UserManagementApp.Models;

namespace UserManagementApp.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UsersResponse> GetUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<UsersResponse>("https://reqres.in/api/users");
        }

        public async Task<UserResponse> GetUserAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<UserResponse>($"https://reqres.in/api/users/{1}");
        }

        public async Task<HttpResponseMessage> CreateUserAsync(CreateUser user)
        {
            return await _httpClient.PostAsJsonAsync("https://reqres.in/api/users", user);
        }
    }
}
