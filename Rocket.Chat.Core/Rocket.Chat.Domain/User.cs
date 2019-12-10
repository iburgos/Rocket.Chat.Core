using Newtonsoft.Json;
using Rocket.Chat.Domain.Authentication;
using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class User
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "utcOffset")]
        public int UtcOffset { get; set; }

        [JsonProperty(PropertyName = "createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "services")]
        public Services Services { get; set; }

        [JsonProperty(PropertyName = "emails")]
        public IEnumerable<Email> Emails { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "roles")]
        public IEnumerable<string> Roles { get; set; }

        [JsonProperty(PropertyName = "_updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "settings")]
        public Settings Settings { get; set; }

        public override string ToString()
        {
            return $"{Username} ({Id})";
        }
    }
}