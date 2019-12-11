using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Users
    {
        [JsonProperty("users")]
        public IEnumerable<User> _Users { get; set; }

        [JsonProperty("full")]
        public bool Full { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}