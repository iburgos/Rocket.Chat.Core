using Newtonsoft.Json;

namespace Rocket.Chat.Domain
{
    public class Preferences
    {
        [JsonProperty("preferences")]
        public Preference _Preferences { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
