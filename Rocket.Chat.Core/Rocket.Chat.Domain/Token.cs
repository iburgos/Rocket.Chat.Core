using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain
{
    public class Token
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "lastTokenPart")]
        public string LastTokenPart { get; set; }
    }
}