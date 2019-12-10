using Newtonsoft.Json;

namespace Rocket.Chat.Domain
{
    public class Email
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }
}