namespace Rocket.Chat.Domain
{
    using System;

    using Newtonsoft.Json;

    public class Channel
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "fname")]
        public string Fname { get; set; }

        [JsonProperty(PropertyName = "t")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "usernames")]
        public string UserNames { get; set; }

        [JsonProperty(PropertyName = "msgs")]
        public int Messages { get; set; }

        [JsonProperty(PropertyName = "usersCount")]
        public int UsersCount { get; set; }

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

        [JsonProperty(PropertyName = "broadcast")]
        public bool Broadcast { get; set; }

        [JsonProperty(PropertyName = "encrypted")]
        public bool Encrypted { get; set; }

        [JsonProperty(PropertyName = "default")]
        public bool Default { get; set; }

        [JsonProperty(PropertyName = "joinCodeRequired")]
        public bool JoinCodeRequired { get; set; }
    }
}