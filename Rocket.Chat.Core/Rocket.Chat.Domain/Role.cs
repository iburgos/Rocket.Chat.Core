using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Role
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "rid")]
        public string RoomId { get; set; }

        [JsonProperty(PropertyName = "u")]
        public User User { get; set; }

        [JsonProperty(PropertyName = "roles")]
        public IEnumerable<string> Roles { get; set; }
    }
}
