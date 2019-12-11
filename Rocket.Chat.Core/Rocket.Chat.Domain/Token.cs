using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain
{
    public class Token
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("lastTokenPart")]
        public string LastTokenPart { get; set; }
    }
}