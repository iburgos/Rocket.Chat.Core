using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Moderators
    {
        [JsonProperty(PropertyName = "moderators")]
        public IEnumerable<User> _Moderators { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}