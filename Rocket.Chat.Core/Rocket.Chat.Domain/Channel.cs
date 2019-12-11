namespace Rocket.Chat.Domain
{
    using System;

    using Newtonsoft.Json;

    public class Channel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("t")]
        public string Type { get; set; }

        [JsonProperty("usernames")]
        public string UserNames { get; set; }

        [JsonProperty("msgs")]
        public int Messages { get; set; }

        [JsonProperty("usersCount")]
        public int UsersCount { get; set; }

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

        [JsonProperty("broadcast")]
        public bool Broadcast { get; set; }

        [JsonProperty("encrypted")]
        public bool Encrypted { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("joinCodeRequired")]
        public bool JoinCodeRequired { get; set; }
    }
}