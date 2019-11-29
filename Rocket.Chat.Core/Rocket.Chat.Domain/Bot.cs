using Newtonsoft.Json;

namespace Rocket.Chat.Domain
{
    public class Bot
    {
        [JsonProperty(PropertyName = "i")]
        public string Id { get; set; }
    }
}