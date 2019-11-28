using Newtonsoft.Json;
using System;

namespace Rocket.Chat.Domain.MethodResults
{
    public class InfoResult
    {
        [JsonProperty("success")]
        public string Success { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("build")]
        public Build Build { get; set; }

        [JsonProperty("commit")]
        public Commit Commit { get; set; }
    }

    public class Commit
    {
        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("branch")]
        public string Branch { get; set; }
    }

    public class Build
    {
        [JsonProperty("nodeVersion")]
        public string NodeVersion { get; set; }

        [JsonProperty("arch")]
        public string Arch { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("cpus")]
        public int CPUs { get; set; }
    }
}