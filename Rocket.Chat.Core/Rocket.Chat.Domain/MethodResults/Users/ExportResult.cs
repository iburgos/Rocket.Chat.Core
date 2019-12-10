using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Rocket.Chat.Domain.MethodResults.Users
{
    public class ExportResult
    {
        [JsonProperty(PropertyName = "requested")]
        public bool Requested { get; set; }

        [JsonProperty(PropertyName = "exportOperation")]
        public ExportData ExportOperation { get; set; }

        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }
    }

    public class ExportData
    {
        [JsonProperty(PropertyName = "_id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty(PropertyName = "userId")]
        public string UserId { get; set; }

        [JsonProperty(PropertyName = "roomList")]
        public IEnumerable<Room> RoomList { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "exportPath")]
        public string ExportPath { get; set; }

        [JsonProperty(PropertyName = "assetsPath")]
        public string AssetsPath { get; set; }

        [JsonProperty(PropertyName = "fileList")]
        public IEnumerable<string> FileList { get; set; }

        [JsonProperty(PropertyName = "generatedFile")]
        public string GeneratedFile { get; set; }

        [JsonProperty(PropertyName = "fullExport")]
        public bool FullExport { get; set; }

        [JsonProperty(PropertyName = "_updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}