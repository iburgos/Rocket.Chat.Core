using System.Collections.Generic;

using Newtonsoft.Json;

namespace Rocket.Chat.Domain
{
    public class Channels
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("channels")]
        public List<Channel> _Channels { get; set; }
    }
}