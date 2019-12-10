using Newtonsoft.Json;

namespace Rocket.Chat.Domain.MethodResults
{
    public class CreateRoomResult
    {
        [JsonProperty("rid")]
        public string RoomId { get; set; }
    }
}