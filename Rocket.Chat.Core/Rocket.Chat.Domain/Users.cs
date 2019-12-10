using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Users
    {
        [JsonProperty(PropertyName = "users")]
        public IEnumerable<User> _Users { get; set; }

        [JsonProperty(PropertyName = "full")]
        public bool Full { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}