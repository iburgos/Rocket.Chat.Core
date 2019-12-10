using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket.Chat.Domain
{
    public class Threads
    {
        [JsonProperty(PropertyName = "threads")]
        public IEnumerable<Thread> _Threads { get; set; }

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
