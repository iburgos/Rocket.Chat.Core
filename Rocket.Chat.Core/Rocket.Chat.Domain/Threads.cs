using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket.Chat.Domain
{
    public class Threads
    {
        [JsonProperty("threads")]
        public IEnumerable<Thread> _Threads { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
