using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Update
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("t")]
        public string Type { get; set; }

        [JsonProperty("u")]
        public User Owner { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("aliases")]
        public IEnumerable<string> Aliases { get; set; }
    }
}