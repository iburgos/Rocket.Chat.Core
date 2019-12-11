using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Mention
    {

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("rid")]
        public string RoomId { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }

        [JsonProperty("ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty("u")]
        public User Owner { get; set; }

        [JsonProperty("mentions")]
        public IEnumerable<User> Mentions { get; set; }

        [JsonProperty("channels")]
        public IEnumerable<Channel> Channels { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}