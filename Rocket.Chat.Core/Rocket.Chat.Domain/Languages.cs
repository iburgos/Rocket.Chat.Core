using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Languages
    {
        [JsonProperty("languages")]
        public IEnumerable<Language> _Languages { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}