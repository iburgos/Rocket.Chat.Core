using Newtonsoft.Json;
using Rocket.Chat.Domain.Authentication;
using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class User
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("utcOffset")]
        public int UtcOffset { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("services")]
        public Services Services { get; set; }

        [JsonProperty("emails")]
        public IEnumerable<Email> Emails { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("roles")]
        public IEnumerable<string> Roles { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        public override string ToString()
        {
            return $"{Username} ({Id})";
        }
    }
}