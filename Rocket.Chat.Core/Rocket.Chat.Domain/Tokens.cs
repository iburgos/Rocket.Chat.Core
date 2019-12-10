using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Tokens
    {
        [JsonProperty(PropertyName = "tokens")]
        public IEnumerable<Token> _Tokens { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}