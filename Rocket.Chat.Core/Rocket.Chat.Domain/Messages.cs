using System.Collections.Generic;

using Newtonsoft.Json;

using Rocket.Chat.Domain.JsonConverters;

namespace Rocket.Chat.Domain
{
    public class Messages
    {
        [JsonProperty(PropertyName = "messages")]
        public IEnumerable<Message> _Messages { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}