using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Integrations
    {
        [JsonProperty("integrations")]
        public IEnumerable<Integration> _Integrations { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
