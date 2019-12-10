using Newtonsoft.Json;

namespace Rocket.Chat.Domain
{
    public class Preferences
    {
        [JsonProperty(PropertyName = "preferences")]
        public Preference _Preferences { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }
}
