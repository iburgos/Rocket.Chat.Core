using Microsoft.Extensions.Caching.Memory;
using RestSharp;
using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Api.Core.Services;
using SimpleInjector;

namespace Rocket.Chat.Api.Core
{
    public class RocketChat
    {
        public IRocketChatApi Api { get; }

        public RocketChat(string serverUrl)
        {
            var container = new Container();
            container.Register<IRestClient>(() => new RestClient(serverUrl));
            container.Register<IJsonConvertHelper, JsonConvertHelper>();
            container.Register<IRestClientService, RestClientService>();
            container.Register<ILoginService, LoginService>();
            container.Register<IChannelsService, ChannelsService>();
            container.Register<IRocketChatApi, RocketChatApi>();
            container.Register<IAuthService, AuthService>();

            var options = new MemoryCacheOptions
            {
                ExpirationScanFrequency = new System.TimeSpan(days: 1, hours: 0, minutes: 0, seconds: 0)
            };

            container.Register<IMemoryCache>(() => new MemoryCache(options), Lifestyle.Singleton);

            container.Verify();

            Api = container.GetInstance<IRocketChatApi>();
        }       
    }
}