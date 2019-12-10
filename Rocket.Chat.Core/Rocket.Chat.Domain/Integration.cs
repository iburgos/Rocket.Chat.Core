using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain
{
    public class Integration
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("triggerWords")]
        public IEnumerable<string> TriggerWords { get; set; }

        [JsonProperty("urls")]
        public IEnumerable<string> Urls { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("script")]
        public string Script { get; set; }

        [JsonProperty("scriptEnabled")]
        public bool ScriptEnabled { get; set; }

        [JsonProperty("impersonateUser")]
        public bool ImpersonateUser { get; set; }

        [JsonProperty("scriptCompiled")]
        public string ScriptCompiled { get; set; }

        [JsonProperty("scriptError")]
        public string ScriptError { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("channel")]
        public IEnumerable<Channel> Channel { get; set; }

        [JsonProperty("_createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("_createdBy")]
        public User CreatedBy { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}