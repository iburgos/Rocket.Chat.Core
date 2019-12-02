using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain
{
    public class Counters
    {
        [JsonProperty(PropertyName = "joined")]
        public bool Joined { get; set; }

        [JsonProperty(PropertyName = "members")]
        public int Members { get; set; }

        [JsonProperty(PropertyName = "unreads")]
        public int Unreads { get; set; }

        [JsonProperty(PropertyName = "unreadsFrom")]
        public DateTime UnreadsFrom { get; set; }

        [JsonProperty(PropertyName = "msgs")]
        public int Messages { get; set; }

        [JsonProperty(PropertyName = "latest")]
        public DateTime Latest { get; set; }

        [JsonProperty(PropertyName = "userMentions")]
        public int UserMentions { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}