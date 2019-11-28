using Newtonsoft.Json;

namespace Rocket.Chat.Domain.MethodResults.Login
{
    public class LogoutResult
    {
        [JsonProperty(PropertyName = "status")]
        public LoginStatus Status { get; set; }

        [JsonProperty(PropertyName = "data")]
        public LogoutData Data { get; set; }
    }

    public class LogoutData
    {
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
