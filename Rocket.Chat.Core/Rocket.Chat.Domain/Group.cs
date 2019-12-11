using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain
{
    public class Group
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("t")]
        public string Type { get; set; }

        [JsonProperty("msgs")]
        public int Messages { get; set; }

        [JsonProperty("u")]
        public User Owner { get; set; }

        [JsonProperty("ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty("ro")]
        public bool ReadOnly { get; set; }

        [JsonProperty("sysMes")]
        public bool SystemMessage { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}