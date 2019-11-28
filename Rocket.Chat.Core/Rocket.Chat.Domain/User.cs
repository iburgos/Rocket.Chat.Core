using Newtonsoft.Json;

namespace Rocket.Chat.Domain
{
    public class User
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        public string Username { get; set; }

        public override string ToString()
        {
            return $"{Username} ({Id})";
        }
    }
}