using RestSharp;
using Rocket.Chat.Api.Core.RestHelpers;
using Rocket.Chat.Api.Core.Services;
using SimpleInjector;
using System;

namespace Rocket.Chat.Api.Core.SimpleInjector
{
    public class RocketChatContainer: IDisposable
    {
        public IRocketChatApi Api { get; }

        private readonly Container _container;

        public RocketChatContainer(string serverUrl)
        {
            _container = new Container();
            
            RegisterServices();

            _container.Register<IRestClient>(() => new RestClient(serverUrl));
            _container.Register<IJsonSerializer, JsonSerializer>();
            _container.Register<IRocketChatApi, RocketChatApi>();
            _container.Register<IAuthHelper, AuthHelper>();
            
            _container.Verify();

            Api = _container.GetInstance<IRocketChatApi>();
        }


        private void RegisterServices()
        {
            _container.Register<IRestClientService, RestClientService>();
            _container.Register<IAuthenticationService, AuthenticationService>();
            _container.Register<IChannelsService, ChannelsService>();
            _container.Register<IGroupsService, GroupsService>();
            _container.Register<IUsersService, UsersService>();
            _container.Register<IChatService, ChatService>();
            _container.Register<IRoomService, RoomService>();
            _container.Register<IAssetsService, AssetsService>();
            _container.Register<IAutoTranslateService, AutoTranslateService>();
            _container.Register<ICommandsService, CommandsService>();
        }

        public void Dispose()
        {
            if (_container != null)
            {
                _container.Dispose();
            }
        }
    }
}