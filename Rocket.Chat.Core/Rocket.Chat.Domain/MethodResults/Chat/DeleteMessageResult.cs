using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain.MethodResults.Chat
{
    public class DeleteMessageResult
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}