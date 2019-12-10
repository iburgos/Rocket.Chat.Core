using Newtonsoft.Json;

namespace Rocket.Chat.Domain.MethodResults.Chat
{
    public class MessageResult
    {
        [JsonProperty(PropertyName = "message")]
        public Message Message { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}