using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Moderators
    {
        [JsonProperty("moderators")]
        public IEnumerable<User> _Moderators { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}