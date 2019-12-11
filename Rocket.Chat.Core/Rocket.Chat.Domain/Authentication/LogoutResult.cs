using Newtonsoft.Json;

namespace Rocket.Chat.Domain.Authentication
{
    public class LogoutResult
    {
        [JsonProperty("status")]
        public LoginStatus Status { get; set; }

        [JsonProperty("data")]
        public LogoutData Data { get; set; }
    }

    public class LogoutData
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
