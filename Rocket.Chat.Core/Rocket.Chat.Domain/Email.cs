using Newtonsoft.Json;

namespace Rocket.Chat.Domain
{
    public class Email
    {
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "verified")]
        public bool Verified { get; set; }
    }
}