using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain.MethodResults.Users
{
    public class ExportResult
    {
        [JsonProperty("requested")]
        public bool Requested { get; set; }

        [JsonProperty("exportOperation")]
        public ExportData ExportOperation { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ExportData
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("roomList")]
        public IEnumerable<Room> RoomList { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("exportPath")]
        public string ExportPath { get; set; }

        [JsonProperty("assetsPath")]
        public string AssetsPath { get; set; }

        [JsonProperty("fileList")]
        public IEnumerable<string> FileList { get; set; }

        [JsonProperty("generatedFile")]
        public string GeneratedFile { get; set; }

        [JsonProperty("fullExport")]
        public bool FullExport { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}