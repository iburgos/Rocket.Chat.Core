namespace Rocket.Chat.Domain.MethodResults
{
    using Newtonsoft.Json;

    public class CreateRoomResult
    {
        [JsonProperty(PropertyName = "rid")]
        public string RoomId { get; set; }
    }
}