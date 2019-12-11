using System.Diagnostics.CodeAnalysis;

using Newtonsoft.Json;

namespace Rocket.Chat.Domain.MethodResults
{
    public class MethodResult<T>
    {
        [JsonProperty("msg")]
        public string ResponseType { get; set; }

        public string Id { get; set; }

        public T Result { get; set; }

        [JsonProperty("error")]
        public ErrorResult Error { get; set; }

        public bool HasError => Error != null;
    }

    public class CallResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("errorType")]
        public string ErrorType { get; set; }
    }
}