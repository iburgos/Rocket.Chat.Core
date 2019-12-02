using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Integrations
    {
        [JsonProperty(PropertyName = "integrations")]
        public IEnumerable<Integration> _Integrations { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}
