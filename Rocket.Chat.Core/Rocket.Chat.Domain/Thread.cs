using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Thread
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "rid")]
        public string RoomId { get; set; }

        [JsonProperty(PropertyName = "msg")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty(PropertyName = "u")]
        public User User { get; set; }

        [JsonProperty(PropertyName = "_updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty(PropertyName = "mentions")]
        public IEnumerable<User> Mentions { get; set; }

        [JsonProperty(PropertyName = "channels")]
        public IEnumerable<Channel> Channels { get; set; }

        [JsonProperty(PropertyName = "replies")]
        public IEnumerable<string> Replies { get; set; }

        [JsonProperty(PropertyName = "tcount")]
        public int TotalCount { get; set; }

        [JsonProperty(PropertyName = "tlm")]
        public DateTime Tlm { get; set; }
    }
}