using Newtonsoft.Json;

namespace Rocket.Chat.Domain.Requests
{
    public class LoginRequest
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}