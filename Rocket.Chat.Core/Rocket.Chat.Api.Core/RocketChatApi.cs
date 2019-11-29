using Rocket.Chat.Api.Core.Services;

namespace Rocket.Chat.Api.Core
{
    public interface IRocketChatApi
    {
        IUsersService Users { get; }
        IGroupsService Groups { get; }
        IChannelsService Channels { get; }
        IAuthenticationService Authentication { get; }
    }

    public class RocketChatApi : IRocketChatApi
    {
        public RocketChatApi(
            IUsersService usersService,
            IGroupsService groupsService,
            IChannelsService channelsService,
            IAuthenticationService authenticationService)
        {
            Users = usersService;
            Groups = groupsService;
            Channels = channelsService;
            Authentication = authenticationService;
        }

        public IUsersService Users { get; }
        public IGroupsService Groups { get; }
        public IChannelsService Channels { get; }
        public IAuthenticationService Authentication { get; }
    }
}