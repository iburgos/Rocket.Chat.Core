using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Groups
    {
        [JsonProperty(PropertyName = "groups")]
        public IEnumerable<Group> _Groups { get; set; }

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