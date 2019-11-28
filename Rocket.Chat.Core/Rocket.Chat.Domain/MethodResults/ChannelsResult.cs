namespace Rocket.Chat.Domain.MethodResults
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class ChannelsResult
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "channels")]
        public List<Channel> Channels { get; set; }
    }

    public class Channel
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "t")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "usernames")]
        public string UserNames { get; set; }

        [JsonProperty(PropertyName = "msgs")]
        public int Messages { get; set; }

        [JsonProperty(PropertyName = "u")]
        public User User { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty(PropertyName = "ro")]
        public string ro { get; set; }

        [JsonProperty(PropertyName = "sysMes")]
        public string sysMes { get; set; }

        [JsonProperty(PropertyName = "_updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}