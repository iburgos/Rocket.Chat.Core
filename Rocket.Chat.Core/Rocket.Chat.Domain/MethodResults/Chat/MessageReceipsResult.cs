using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Domain.MethodResults.Chat
{
    public class MessageReceipsResult
    {
        [JsonProperty(PropertyName = "receipts")]
        public IEnumerable<Receipt> Receipts { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}