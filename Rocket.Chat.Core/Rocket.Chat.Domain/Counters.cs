using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain
{
    public class Counters
    {
        [JsonProperty("joined")]
        public bool Joined { get; set; }

        [JsonProperty("members")]
        public int Members { get; set; }

        [JsonProperty("unreads")]
        public int Unreads { get; set; }

        [JsonProperty("unreadsFrom")]
        public DateTime UnreadsFrom { get; set; }

        [JsonProperty("msgs")]
        public int Messages { get; set; }

        [JsonProperty("latest")]
        public DateTime Latest { get; set; }

        [JsonProperty("userMentions")]
        public int UserMentions { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}