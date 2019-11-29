namespace Rocket.Chat.Domain.MethodResults
{
    using System.Diagnostics.CodeAnalysis;

    using Newtonsoft.Json;

    public class MethodResult<T>
    {
        [JsonProperty(PropertyName = "msg")]
        public string ResponseType { get; set; }

        public string Id { get; set; }

        public T Result { get; set; }

        [JsonProperty(PropertyName = "error")]
        public ErrorResult Error { get; set; }

        public bool HasError => Error != null;
    }

    public class CallResult
    {
        [JsonProperty(PropertyName = "success")]
        public bool Success { get; set; }

        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        [JsonProperty(PropertyName = "errorType")]
        public string ErrorType { get; set; }
    }
}