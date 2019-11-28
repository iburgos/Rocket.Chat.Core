using Newtonsoft.Json;
using System.Collections.Generic;

namespace Rocket.Chat.Api.Core
{
    public interface IJsonConvertHelper
    {
        string Serialize<T>(T value);
        T Deserialize<T>(string value);
    }

    public class JsonConvertHelper : IJsonConvertHelper
    {
        private JsonSerializerSettings _settings => new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Objects,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            Converters = new List<JsonConverter> {
            }
        };

        public string Serialize<T>(T value)
        {
            return JsonConvert.SerializeObject(value, _settings);
        }

        public T Deserialize<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value, _settings);
        }
    }
}