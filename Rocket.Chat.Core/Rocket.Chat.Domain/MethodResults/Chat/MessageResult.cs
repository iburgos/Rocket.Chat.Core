using Newtonsoft.Json;

namespace Rocket.Chat.Domain.MethodResults.Chat
{
    public class MessageResult
    {
        [JsonProperty("message")]
        public Message Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}