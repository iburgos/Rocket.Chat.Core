using Rocket.Chat.Api.Core.Services;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Rocket.Chat.Api.Core.SimpleInjector")]
namespace Rocket.Chat.Api.Core
{
    public interface IRocketChatApi
    {
        IChatService Chat { get; }
        IUsersService Users { get; }
        IGroupsService Groups { get; }
        IChannelsService Channels { get; }
        IAuthenticationService Authentication { get; }
        IRoomService RoomService { get; }
        IAssetsService AssetsService { get; }
        IAutoTranslateService AutoTranslateService { get; }
    }

    internal class RocketChatApi : IRocketChatApi
    {
        public RocketChatApi(
            IChatService chatService,
            IUsersService usersService,
            IGroupsService groupsService,
            IChannelsService channelsService,
            IAuthenticationService authenticationService,
            IRoomService roomService,
            IAssetsService assetsService,
            IAutoTranslateService autoTranslateService)
        {
            Chat = chatService;
            Users = usersService;
            Groups = groupsService;
            Channels = channelsService;
            Authentication = authenticationService;
            RoomService = roomService;
            AssetsService = assetsService;
            AutoTranslateService = autoTranslateService;
        }

        public IChatService Chat { get; }
        public IUsersService Users { get; }
        public IGroupsService Groups { get; }
        public IChannelsService Channels { get; }
        public IAuthenticationService Authentication { get; }
        public IRoomService RoomService { get; }
        public IAssetsService AssetsService { get; }
        public IAutoTranslateService AutoTranslateService { get; }
    }
}