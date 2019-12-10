using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain.MethodResults.Chat
{
    public class PostMessageResult
    {
        [JsonProperty(PropertyName = "ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty(PropertyName = "channel")]
        public string Channel { get; set; }

        [JsonProperty(PropertyName = "message")]
        public Message Message { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}