using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Rocket.Chat.Domain.MethodResults
{
    public class CollectionResult
    {
        [JsonProperty("collection")]
        public string Name { get; set; }

        public string Id { get; set; }

        public JObject Fields { get; set; }
    }
}