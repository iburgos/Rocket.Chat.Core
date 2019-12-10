using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Rocket.Chat.Domain
{
    public class RoomInfo
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("ts")]
        public DateTime? Timestamp { get; set; }

        [JsonProperty("t")]
        public RoomType Type { get; set; }

        public string Name { get; set; }

        [JsonProperty("lm")]
        public DateTime? LastMessage { get; set; }

        [JsonProperty("msgs")]
        public int? MessageCount { get; set; }

        [JsonProperty("usernames")]
        public IList<string> Usersnames { get; set; }

        [JsonProperty("u")]
        public User Owner { get; set; }
    }
}