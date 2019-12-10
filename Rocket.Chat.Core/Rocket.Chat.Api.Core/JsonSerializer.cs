using Newtonsoft.Json;

namespace Rocket.Chat.Api.Core
{
    public interface IJsonSerializer
    {
        string Serialize(object obj);
        T Deserialize<T>(string value);
    }

    public class JsonSerializer : IJsonSerializer
    {
        private readonly JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            MissingMemberHandling = MissingMemberHandling.Ignore
        };

        public string ContentType { get; set; }

        public T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value, _settings);
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, _settings);
        }
    }
}