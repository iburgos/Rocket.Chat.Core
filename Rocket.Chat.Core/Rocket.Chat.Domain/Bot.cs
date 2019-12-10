using Newtonsoft.Json;

namespace Rocket.Chat.Domain
{
    public class Bot
    {
        [JsonProperty("i")]
        public string Id { get; set; }
    }
}