using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain
{
    public class Discussion
    {
        [JsonProperty("rid")]
        public string RoomId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("fname")]
        public string Fname { get; set; }

        [JsonProperty("t")]
        public string Type { get; set; }

        [JsonProperty("msgs")]
        public int Messages { get; set; }

        [JsonProperty("usersCount")]
        public int UsersCount { get; set; }

        [JsonProperty("u")]
        public User Owner { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("prid")]
        public string ParentRoomId { get; set; }

        [JsonProperty("ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty("ro")]
        public bool ReadOnly { get; set; }

        [JsonProperty("sysMes")]
        public bool SystemMessage { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }
    }
}
