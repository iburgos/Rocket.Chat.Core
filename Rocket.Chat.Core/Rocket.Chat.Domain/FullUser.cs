namespace Rocket.Chat.Domain
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    using Rocket.Chat.Domain.JsonConverters;

    public class FullUser
    {
        public string Id { get; set; }

        [JsonConverter(typeof(MeteorDateConverter))]
        public DateTime CreatedAt { get; set; }

        public string Username { get; set; }

        public List<Email> Emails { get; set; }

        public string Status { get; set; }

        public bool Active { get; set; }

        public List<string> Roles { get; set; }
    }
}