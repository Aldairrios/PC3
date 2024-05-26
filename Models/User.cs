using System.Text.Json.Serialization;

namespace UserManagementApp.Models
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    }

    public class CreateUser
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("job")]
        public string Job { get; set; }
    }

    public class UserResponse
    {
        [JsonPropertyName("data")]
        public User Data { get; set; }
    }

    public class UsersResponse
    {
        [JsonPropertyName("data")]
        public List<User> Data { get; set; }
    }
}