﻿using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain
{
    public class Group
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "t")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "msgs")]
        public int Messages { get; set; }

        [JsonProperty(PropertyName = "u")]
        public User User { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty(PropertyName = "ro")]
        public bool ro { get; set; }

        [JsonProperty(PropertyName = "sysMes")]
        public bool sysMes { get; set; }

        [JsonProperty(PropertyName = "_updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}