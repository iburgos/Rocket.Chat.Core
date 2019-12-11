using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Emoji
    {
        [JsonProperty("update")]
        public IEnumerable<Update> Update { get; set; }

        [JsonProperty("remove")]
        public IEnumerable<Update> Remove { get; set; }
    }
}