using Newtonsoft.Json;

namespace Rocket.Chat.Domain
{
    public class Language
    {
        [JsonProperty("language")]
        public string _Language { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}