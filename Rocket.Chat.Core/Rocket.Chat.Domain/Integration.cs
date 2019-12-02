using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Integration
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "enabled")]
        public bool Enabled { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "alias")]
        public string Alias { get; set; }

        [JsonProperty(PropertyName = "avatar")]
        public string Avatar { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "triggerWords")]
        public IEnumerable<string> TriggerWords { get; set; }

        [JsonProperty(PropertyName = "urls")]
        public IEnumerable<string> Urls { get; set; }

        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }

        [JsonProperty(PropertyName = "script")]
        public string Script { get; set; }

        [JsonProperty(PropertyName = "scriptEnabled")]
        public bool ScriptEnabled { get; set; }

        [JsonProperty(PropertyName = "impersonateUser")]
        public bool ImpersonateUser { get; set; }

        [JsonProperty(PropertyName = "scriptCompiled")]
        public string ScriptCompiled { get; set; }

        [JsonProperty(PropertyName = "scriptError")]
        public string ScriptError { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "channel")]
        public IEnumerable<Channel> Channel { get; set; }

        [JsonProperty(PropertyName = "_createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "_createdBy")]
        public User CreatedBy { get; set; }

        [JsonProperty(PropertyName = "_updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}