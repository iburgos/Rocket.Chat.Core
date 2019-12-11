using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Emojis
    {
        [JsonProperty("emojis")]
        public IEnumerable<Emoji> _Emojis { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}