using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain.MethodResults.Chat
{
    public class DeleteMessageResult
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}