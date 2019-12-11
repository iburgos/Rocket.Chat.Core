using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain
{
    public class File
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("rid")]
        public string RoomId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("store")]
        public string Store { get; set; }

        [JsonProperty("complete")]
        public bool Complete { get; set; }

        [JsonProperty("uploading")]
        public bool Uploading { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("instanceId")]
        public string InstanceId { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("uploadedAt")]
        public DateTime UploadedAt { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}