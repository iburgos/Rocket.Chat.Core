using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Tokens
    {
        [JsonProperty("tokens")]
        public IEnumerable<Token> _Tokens { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}