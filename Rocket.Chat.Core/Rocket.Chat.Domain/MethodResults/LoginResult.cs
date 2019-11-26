namespace Rocket.Chat.Domain.MethodResults
{
    using System;

    using Newtonsoft.Json;

    using Rocket.Chat.Domain.JsonConverters;

    public class LoginResult
    {
        [JsonProperty(PropertyName = "id")]
        public string UserId { get; set; }

        public string Token { get; set; }

        [JsonConverter(typeof(MeteorDateConverter))]
        public DateTime TokenExpires { get; set; }
    }
}