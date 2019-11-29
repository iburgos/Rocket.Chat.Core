namespace Rocket.Chat.Domain
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class Channels
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "channels")]
        public List<Channel> _Channels { get; set; }
    }
}