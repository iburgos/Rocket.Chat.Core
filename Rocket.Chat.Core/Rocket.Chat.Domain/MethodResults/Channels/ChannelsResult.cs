using System.Collections.Generic;

using Newtonsoft.Json;

namespace Rocket.Chat.Domain.MethodResults.Channels
{
    public class ChannelsResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("channels")]
        public IEnumerable<Channel> _Channels { get; set; }
    }
}