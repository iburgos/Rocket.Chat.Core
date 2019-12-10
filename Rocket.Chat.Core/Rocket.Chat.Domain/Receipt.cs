using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain
{
    public class Receipt
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "roomId")]
        public string RoomId { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

        [JsonProperty(PropertyName = "ts")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }
    }
}