using Rocket.Chat.Api.Core.Services;

namespace Rocket.Chat.Api.Core
{
    public interface IRocketChatApi
    {
        IChatService Chat { get; }
        IUsersService Users { get; }
        IGroupsService Groups { get; }
        IChannelsService Channels { get; }
        IAuthenticationService Authentication { get; }
    }

    public class RocketChatApi : IRocketChatApi
    {
        public RocketChatApi(
            IChatService chatService,
            IUsersService usersService,
            IGroupsService groupsService,
            IChannelsService channelsService,
            IAuthenticationService authenticationService)
        {
            Chat = chatService;
            Users = usersService;
            Groups = groupsService;
            Channels = channelsService;
            Authentication = authenticationService;
        }

        public IChatService Chat { get; }
        public IUsersService Users { get; }
        public IGroupsService Groups { get; }
        public IChannelsService Channels { get; }
        public IAuthenticationService Authentication { get; }
    }
}