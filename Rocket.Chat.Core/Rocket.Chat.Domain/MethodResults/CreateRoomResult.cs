using Newtonsoft.Json;

namespace Rocket.Chat.Domain.MethodResults
{
    public class CreateRoomResult
    {
        [JsonProperty(PropertyName = "rid")]
        public string RoomId { get; set; }
    }
}